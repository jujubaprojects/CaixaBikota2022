using ClosedXML.Excel;
using Componentes;
using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Collections.Generic;
using System.Text;

namespace Caixa.RH
{
    public partial class frmCalculoHoras : FormJCS
    {
        private SQL.SQL auxSQL = new SQL.SQL();
        private string pastaInicial = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
        "Dropbox",
        "Bikota",
        "Documentos",
        "Recibos"
    );

        public frmCalculoHoras()
        {
            InitializeComponent();
        }

        public string ConverterXlsParaXlsx(string caminhoXls)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var wb = excelApp.Workbooks.Open(caminhoXls);

            string novoCaminho = Path.ChangeExtension(caminhoXls, ".xlsx");

            wb.SaveAs(novoCaminho, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
            wb.Close(false);
            excelApp.Quit();

            return novoCaminho;
        }

        public void executaCalculo(string caminhoExcel, string pastaSaida)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(caminhoExcel, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var dataSet = reader.AsDataSet();
                var tabela = dataSet.Tables["Registro de atendimento"]; // primeira aba

                int linha = 2; // começa na linha 3 (índice 2)

                //PEGAR INFORMACAO DO MES E ANO DA PLANILHA
                string valorBruto = tabela.Rows[1][2]?.ToString()?.Trim();
                DateTime dataInicial = DateTime.Parse(valorBruto.Split('~')[0].Trim());

                while (linha < tabela.Rows.Count)
                {
                    try
                    {

                        var rowInfo = tabela.Rows[linha];

                        // ID (coluna C = index 2)
                        if (rowInfo[2] == null || string.IsNullOrWhiteSpace(rowInfo[2].ToString()))
                        {
                            linha++;
                            continue;
                        }

                        int id = Convert.ToInt32(rowInfo[2]);
                        string nome = rowInfo[11]?.ToString()?.Trim() ?? "SEM_NOME";

                        var resultado = new List<string>();
                        resultado.Add($"Funcionário: {nome} (ID {id})");
                        resultado.Add("Dia | Tempo (min) | Extra (min)");

                        int totalMin = 0;
                        int totalExtra = 0;

                        var rowDias = tabela.Rows[linha + 1];   // linha 4
                        var rowPontos = tabela.Rows[linha + 3]; // linha 6

                        DataTable dtAux = auxSQL.retornaDataTable("SELECT QT_MIN_TRAB_DIA FROM COLABORADOR_ESCALA_PONTO WHERE ID_PONTO = " + id);

                        for (int col = 0; col < tabela.Columns.Count; col++)
                        {
                            try
                            {
                                var diaValor = rowDias[col]?.ToString();

                                if (string.IsNullOrWhiteSpace(diaValor))
                                    continue;

                                int dia = Convert.ToInt32(diaValor);

                                var celula = rowPontos[col]?.ToString();

                                if (string.IsNullOrWhiteSpace(celula))
                                {
                                    resultado.Add($"{dia:00}   FOLGA OU FALTA");
                                    continue;
                                }

                                // separa horários (ex: "08:00 12:00 13:00 18:00")
                                var partes = celula.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                                var horarios = new List<TimeSpan>();

                                foreach (var p in partes)
                                {
                                    if (TimeSpan.TryParse(p, out TimeSpan h))
                                        horarios.Add(h);
                                }

                                if (horarios.Count % 2 != 0 || horarios.Count == 0)
                                {
                                    resultado.Add($"{dia:00}   ERRO DE REGISTRO");
                                    continue;
                                }

                                int minutosDia = 0;

                                for (int i = 0; i < horarios.Count; i += 2)
                                {
                                    var entrada = horarios[i];
                                    var saida = horarios[i + 1];

                                    if (saida < entrada)
                                        throw new Exception();

                                    minutosDia += (int)(saida - entrada).TotalMinutes;
                                }

                                bool atencaoLinhaX = false;
                                int escala = 240;
                                if (dtAux.Rows.Count > 0)
                                    int.TryParse(dtAux.Rows[0]["QT_MIN_TRAB_DIA"].ToString(), out escala);



                                if ((int)DateTime.Parse(dia + "/" + dataInicial.ToString("MM/yyyy")).DayOfWeek == 6 && minutosDia < 90)
                                    escala = 0;
                                       

                                int extra = minutosDia - escala;
                                

                                totalMin += minutosDia;
                                totalExtra += extra;

                                if (atencaoLinhaX)
                                    resultado.Add($"{dia:00}   {minutosDia,6}   {extra,6}" + " ATENÇÃO");
                                else
                                    resultado.Add($"{dia:00}   {minutosDia,6}   {extra,6}");
                            }
                            catch
                            {
                                resultado.Add($"{rowDias[col]}   ERRO DE REGISTRO");
                            }
                        }

                        resultado.Add("-----------------------------------");
                        resultado.Add($"Total   {totalMin}   {totalExtra}");

                        // 📁 gera arquivo por funcionário
                        string nomeArquivo = $"{id}_{nome.Replace(" ", "_")}_{dataInicial.ToString("yyyyMM")}.txt";
                        string caminhoFinal = Path.Combine(pastaSaida, nomeArquivo);

                        if (totalMin > 1000)
                            File.WriteAllLines(caminhoFinal, resultado, Encoding.UTF8);

                        // pula para próximo funcionário (estrutura fixa = 6 linhas)
                        linha += 4;
                    }
                    catch
                    {
                        linha++;
                    }
                }
            }
        }
            

            private void btnPlanilha_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Selecione a planilha";
                ofd.Filter = "Arquivos Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
                ofd.Multiselect = false;
                ofd.InitialDirectory = pastaInicial;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtDiretorioPlanilha.Text = ofd.FileName ;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            

            if (!txtDiretorioPlanilha.Text.Equals("Escolha o arquivo da planilha"))
            {
                executaCalculo(txtDiretorioPlanilha.Text, pastaInicial);
                MessageBox.Show("Processamento finalizado!");
            }
            else
                MessageBox.Show("Escolha a planilha para fazer o calculo!", "Escolha o arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
    }
    
}
