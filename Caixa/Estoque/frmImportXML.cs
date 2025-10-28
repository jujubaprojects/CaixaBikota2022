using Componentes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using ExcelDataReader;
using System.Xml.Linq;

namespace Caixa.Estoque
{
    public partial class frmImportXML : FormJCS
    {
        //VARIAVEIS GLOBAIS DESTE FORMULARIO
        private List<string> arquivos;
        private DataTable dtExcelNFe;
        private int qtArquivos = 0;
        private int qtArquivosSemErro = 0;
        private List<string> nomeArquivos;
        private SqlConnection conn;
        private SqlTransaction transacao;
        private dal.Conexao conexao = new dal.Conexao();
        DataTable dtRetornoAux = new DataTable();
        private string IDNFe;
        private SQL.SQL auxSQL = new SQL.SQL();
        private bool tagCNPJ;

        public frmImportXML()
        {
            InitializeComponent();

            txtXML.Text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }
        private void BntImportar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtXML.Text))//SE O TXT DO EXCEL E DO XML NAO FOR NULL, ENTAO EXECUTA A TAREFA
            {
                conn = conexao.retornaConexao();
                transacao = conexao.startTransaction(conn);
                StringBuilder sqlSelect = new StringBuilder();
                StringBuilder sqlInsert = new StringBuilder();
                DataTable dt = new DataTable();
                DataTable dtFornecedor = new DataTable();
                string cnpj = "";
                string teste = "";
                nomeArquivos = new List<string>();
                int qtCompra = 0;
                arquivos = new List<string>();
                arquivos.AddRange(Directory.GetFiles(txtXML.Text));//PEGANDO TODOS OS ARQUIVOS NO CAMINHO DO XML

                try
                {
                    for (int l = 0; l < arquivos.Count(); l++)//LACO PARA EXECUTAR TODOS OS ARQUIVOS, MESMO SENDO XML OU NAO
                    {
                        if (arquivos[l].ToUpper().Contains(".XML"))// || arquivos[l].ToUpper().Contains(".XLSX"))//APENAS XMLs e Excel
                        {
                            //if (arquivos[l].Equals(@"C:\Users\Jujuba\Downloads\NFe31240410975945000859550010004644311849623671.xml"))
                            //    teste = "";

                            dtExcelNFe = new DataTable();
                            //if (arquivos[l].ToUpper().Contains(".XML"))
                            //{
                                //NO METODO ABAIXO EU PEGO APENAS OS XML DO CNPJ CORRETO, EVITANDO IMPORTAÇÃO DE ARQUIVOS INCORRETOS.
                                XmlTextReader reader = new XmlTextReader(arquivos[l]);
                                tagCNPJ = true;
                                while (reader.Read() && tagCNPJ)
                                {
                                    switch (reader.NodeType)
                                    {
                                        case XmlNodeType.Element: // The node is an element.
                                            if (reader.Name.Equals("dest"))
                                            {
                                                tagCNPJ = false;
                                                reader.Read();
                                                reader.Read();
                                            if (reader.Value.ToString().Length == 0)
                                                reader.Read();

                                            if (reader.Value.Equals("20172949000186") || reader.Value.Equals("12279510600"))
                                                {
                                                //dtExcelNFe = buscaTudo(arquivos[l].ToUpper());
                                                dtExcelNFe = LerXML(arquivos[l].ToUpper());

                                            }
                                            }

                                            break;
                                    }
                                }
                            //}
                            //else
                            //    dtExcelNFe = buscaExcel(arquivos[l].ToUpper());

                            SqlCommand sqlComSelect;// = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                            SqlCommand sqlComInsert;
                            //sqlComSelect.CommandType = CommandType.Text;
                            //int testee = int.Parse("asak");

                            for (int i = 0; i < dtExcelNFe.Rows.Count; i++)
                            {
                                //QUANDO INICIAR A INSERCAO, VOU FAZER UMA VALIDACAO COMPARANDO A CHAVE DA NF PARA NAO PRECISAR ACESSAR O DB VARIAS VEZES
                                //if (i > 0)
                                //{
                                //    if (!dtExcelNFe.Rows[i]["INFNFE"].ToString().Equals(dtExcelNFe.Rows[i - 1]["INFNFE"].ToString()))
                                //    {
                                //        sqlSelect.Clear();
                                //        sqlSelect.Append("SELECT * FROM NF WHERE INF_NFE = @pInfNFe");
                                //        sqlComSelect = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                                //        sqlComSelect.CommandType = CommandType.Text;
                                //        sqlComSelect.Parameters.AddWithValue("@pInfNFe", dtExcelNFe.Rows[i]["INFNFE"].ToString());
                                //        dt = auxSQL.retornaDataTableTransaction(conn, sqlComSelect);
                                //    }
                                //}

                                //COMO ESTOU INICIANDO O CONTADOR, EU PRECISO BUSCAR A CHAVE DA NF PRA VER SE JÁ FOI INSERIDO NO SISTEMA
                                //if (i == 0)
                                //{
                                //    sqlSelect.Clear();
                                //    sqlSelect.Append("SELECT * FROM NF WHERE INF_NFE = @pInfNFe");
                                //    sqlComSelect = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                                //    sqlComSelect.CommandType = CommandType.Text;
                                //    sqlComSelect.Parameters.AddWithValue("@pInfNFe", dtExcelNFe.Rows[i]["INFNFE"].ToString());
                                //    dt = auxSQL.retornaDataTableTransaction(conn, sqlComSelect);
                                //}
                                //else
                                //{
                                    sqlSelect.Clear();
                                    sqlSelect.Append("SELECT * FROM NF WHERE INF_NFE = @pInfNFe OR INF_NFE = REPLACE(@pInfNFe, 'NFe', '')");
                                    sqlComSelect = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                                    sqlComSelect.CommandType = CommandType.Text;
                                    sqlComSelect.Parameters.AddWithValue("@pInfNFe", dtExcelNFe.Rows[i]["INFNFE"].ToString());
                                    dt = auxSQL.retornaDataTableTransaction(conn, sqlComSelect);
                                //}

                                //CASO NAO EXISTA ESSA CHAVE DE NF NO SISTEMA, VOU INSERIR ELA E OS PRODUTOS DELA
                                if (dt.Rows.Count == 0)
                                {
                                    cnpj = dtExcelNFe.Rows[i]["CNPJ"].ToString();

                                    sqlSelect.Clear();
                                    sqlSelect.Append("SELECT * FROM FORNECEDOR WHERE CPF_CNPJ = @CNPJ");
                                    sqlComSelect = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                                    sqlComSelect.CommandType = CommandType.Text;
                                    sqlComSelect.Parameters.AddWithValue("@CNPJ", dtExcelNFe.Rows[i]["CNPJ"].ToString());
                                    dtFornecedor = auxSQL.retornaDataTableTransaction(conn, sqlComSelect);

                                    //INSERINDO UM NOVO FORNECEDOR NO SISTEMA, CASO NAO EXISTA
                                    if (dtFornecedor.Rows.Count == 0)
                                    {
                                        sqlInsert.Clear();
                                        sqlInsert.Append("INSERT INTO FORNECEDOR (CPF_CNPJ, NOME, IE, FONE, NOME_FANTASIA, CEP, END_RUA, END_NUM, END_BAIRRO, END_CIDADE, END_UF) ");
                                        sqlInsert.Append("VALUES (@CPF_CNPJ, @NOME, @IE, @FONE, @NOME_FANTASIA, @CEP, @END_RUA, @END_NUM, @END_BAIRRO, @END_CIDADE, @END_UF) ");
                                        sqlComInsert = new SqlCommand(sqlInsert.ToString(), conn, transacao);
                                        sqlComInsert.Parameters.AddWithValue("@CPF_CNPJ", dtExcelNFe.Rows[i]["CNPJ"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@NOME", dtExcelNFe.Rows[i]["XNOME"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@IE", dtExcelNFe.Rows[i]["IE"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@FONE", dtExcelNFe.Rows[i]["FONE"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@NOME_FANTASIA", dtExcelNFe.Rows[i]["XNOME"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@CEP", dtExcelNFe.Rows[i]["CEP"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@END_RUA", dtExcelNFe.Rows[i]["XLGR"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@END_NUM", dtExcelNFe.Rows[i]["NRO"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@END_BAIRRO", dtExcelNFe.Rows[i]["XBAIRRO"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@END_CIDADE", dtExcelNFe.Rows[i]["XMUN"].ToString());
                                        sqlComInsert.Parameters.AddWithValue("@END_UF", dtExcelNFe.Rows[i]["UF"].ToString());
                                        auxSQL.executaQueryTransaction(conn, sqlComInsert);
                                    }

                                    //INSERINDO A NOTA FISCAL NO SISTEMA
                                    sqlInsert.Clear();
                                    sqlInsert.Append("INSERT INTO NF (INF_NFE, COD_NF, N_NF, DT_EMISSAO, DT_ENTREGA, FORNECEDOR, VALOR) ");
                                    sqlInsert.Append("VALUES (@INFNFE, @CODNF, @NNF, @DTEMISSAO, @DTENTREGA, (SELECT ID FROM FORNECEDOR WHERE CPF_CNPJ = @CNPJ), @VALOR) ");
                                    sqlComInsert = new SqlCommand(sqlInsert.ToString(), conn, transacao);
                                    sqlComInsert.Parameters.AddWithValue("@INFNFE", dtExcelNFe.Rows[i]["infNFe"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@CODNF", dtExcelNFe.Rows[i]["cNF"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@NNF", dtExcelNFe.Rows[i]["nNF"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@DTEMISSAO", DateTime.Parse(dtExcelNFe.Rows[i]["dhEmi"].ToString()));
                                    sqlComInsert.Parameters.AddWithValue("@DTENTREGA", DateTime.Parse(dtExcelNFe.Rows[i]["dhSaiEnt"].ToString()));
                                    sqlComInsert.Parameters.AddWithValue("@CNPJ", dtExcelNFe.Rows[i]["CNPJ"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@VALOR", dtExcelNFe.Rows[i]["vLiq"].ToString().Replace(",","."));
                                    auxSQL.executaQueryTransaction(conn, sqlComInsert);

                                    //PERCORRER TODOS OS PRODUTOS PARA INSERIR ELES
                                    for (int j = i; true; j++)
                                    {
                                        if (dtExcelNFe.Rows.Count > j && dtExcelNFe.Rows[i]["INFNFE"].ToString().Equals(dtExcelNFe.Rows[j]["INFNFE"].ToString()))
                                        {
                                            sqlSelect.Clear();
                                            sqlSelect.Append("SELECT * FROM NF_PROD WHERE NF = (SELECT ID FROM NF WHERE INF_NFE = @INF_NFE) AND COD_PROD = @COD_PROD");
                                            sqlComSelect = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                                            sqlComSelect.CommandType = CommandType.Text;
                                            sqlComSelect.Parameters.AddWithValue("@INF_NFE", dtExcelNFe.Rows[j]["infNFe"].ToString());
                                            sqlComSelect.Parameters.AddWithValue("@COD_PROD", dtExcelNFe.Rows[j]["cProd"].ToString());
                                            if (auxSQL.retornaDataTableTransaction(conn, sqlComSelect).Rows.Count > 0)
                                            {
                                                sqlInsert.Clear();
                                                sqlInsert.Append("UPDATE NF_PROD SET QT_COM = QT_COM + @QT_COM ");
                                                sqlInsert.Append("WHERE NF = (SELECT ID FROM NF WHERE INF_NFE = @INF_NFE) AND COD_PROD = @COD_PROD ");
                                                sqlComInsert = new SqlCommand(sqlInsert.ToString(), conn, transacao);
                                                sqlComInsert.Parameters.AddWithValue("@INF_NFE", dtExcelNFe.Rows[j]["infNFe"].ToString());
                                                sqlComInsert.Parameters.AddWithValue("@COD_PROD", dtExcelNFe.Rows[j]["cProd"].ToString());
                                                sqlComInsert.Parameters.AddWithValue("@QT_COM", qtCompra);
                                                auxSQL.executaQueryTransaction(conn, sqlComInsert);
                                            }
                                            else
                                            {
                                                //INSERINDO O PRODUTO DA NF NO SISTEMA
                                                sqlInsert.Clear();
                                                sqlInsert.Append("INSERT INTO NF_PROD(NF, COD_PROD, DESC_PROD, QT_COM, VL_UNIT, UN_COMERCIAL) ");
                                                sqlInsert.Append("VALUES ((SELECT ID FROM NF WHERE INF_NFE = @INF_NFE),@COD_PROD, @DESC_PROD, @QT_COM, @VL_UNIT, @UN_COM )  ");
                                                sqlComInsert = new SqlCommand(sqlInsert.ToString(), conn, transacao);
                                                sqlComInsert.Parameters.AddWithValue("@INF_NFE", dtExcelNFe.Rows[j]["infNFe"].ToString());
                                                sqlComInsert.Parameters.AddWithValue("@COD_PROD", dtExcelNFe.Rows[j]["cProd"].ToString());
                                                sqlComInsert.Parameters.AddWithValue("@DESC_PROD", dtExcelNFe.Rows[j]["xProd"].ToString());
                                                qtCompra = (int)double.Parse(dtExcelNFe.Rows[j]["qCom"].ToString().Replace(".", ","));
                                                sqlComInsert.Parameters.AddWithValue("@VL_UNIT", double.Parse(dtExcelNFe.Rows[j]["vUnCom"].ToString().Replace(".", ",")));
                                                if (dtExcelNFe.Rows[j]["uCom"].ToString().Length > 2)
                                                    sqlComInsert.Parameters.AddWithValue("@UN_COM", dtExcelNFe.Rows[j]["uCom"].ToString().Substring(0, 2).ToUpper());
                                                else
                                                    sqlComInsert.Parameters.AddWithValue("@UN_COM", dtExcelNFe.Rows[j]["uCom"].ToString());

                                                sqlComInsert.Parameters.AddWithValue("@QT_COM", qtCompra);
                                                auxSQL.executaQueryTransaction(conn, sqlComInsert);
                                            }
                                        }
                                        else
                                        {
                                            i = j - 1;
                                            break;
                                        }
                                    }

                                }
                                //else
                                    //break;
                            }



                           // insertProduto();
                        }
                    }
                }
                catch (Exception er)
                {
                    transacao.Rollback();
                    conn.Close();
                    //MessageBox.Show("Erro: " + er.InnerException.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                finally
                {
                    transacao.Commit();
                    conn.Close();
                    MessageBox.Show("Processo concluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }      //FECHANDO TODAS AS INFORMACOES DO COMPONENTE BACKGROUNDWORKER 
            }
            else
            {
                MessageBox.Show("Por favor, informe os caminhos corretos.");
            }
        }


        public DataTable LerXML(string caminhoArquivo)
        {
            XDocument xml = XDocument.Load(caminhoArquivo);
            XNamespace ns = "http://www.portalfiscal.inf.br/nfe";

            var inf = xml.Descendants(ns + "infNFe").First();
            var ide = inf.Element(ns + "ide");
            var emit = inf.Element(ns + "emit");
            var dest = inf.Element(ns + "dest");
            var total = inf.Element(ns + "total")?.Element(ns + "ICMSTot");

            // ✅ Mantém a ordem idêntica à do seu código original
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new[]
            {
            new DataColumn("infNFe"), new DataColumn("cNF"), new DataColumn("nNF"),
            new DataColumn("dhEmi"), new DataColumn("dhSaiEnt"), new DataColumn("CNPJ"),
            new DataColumn("xNome"), new DataColumn("xFant"), new DataColumn("xLgr"),
            new DataColumn("nro"), new DataColumn("xBairro"), new DataColumn("xMun"),
            new DataColumn("UF"), new DataColumn("CEP"), new DataColumn("fone"),
            new DataColumn("IE"), new DataColumn("cProd"), new DataColumn("xProd"),
            new DataColumn("qCom"), new DataColumn("uCom"), new DataColumn("vUnCom"),
            new DataColumn("vLiq")
        });

            // 🔹 Cabeçalho da NF
            string idNFe = (string)inf.Attribute("Id");
            string cNF = (string)ide?.Element(ns + "cNF");
            string nNF = (string)ide?.Element(ns + "nNF");
            string dhEmi = (string)ide?.Element(ns + "dhEmi");
            string dhSaiEnt = (string)ide?.Element(ns + "dhSaiEnt") ?? dhEmi; // usa dhEmi se dhSaiEnt não existir

            // 🔹 Captura CNPJ ou CPF (preenche em "CNPJ")
            string cnpj = (string)dest.Element(ns + "CNPJ") ?? (string)dest.Element(ns + "CPF");
            string nome = (string)dest.Element(ns + "xNome");
            string xFant = (string)emit.Element(ns + "xFant");
            string vLiq = (string)xml.Descendants(ns + "vLiq").FirstOrDefault() ?? (string)total?.Element(ns + "vNF");

            // 🔹 Endereço do destinatário
            var end = dest.Element(ns + "enderDest");
            string xLgr = (string)end?.Element(ns + "xLgr");
            string nro = (string)end?.Element(ns + "nro");
            string xBairro = (string)end?.Element(ns + "xBairro");
            string xMun = (string)end?.Element(ns + "xMun");
            string UF = (string)end?.Element(ns + "UF");
            string CEP = (string)end?.Element(ns + "CEP");
            string fone = (string)end?.Element(ns + "fone");
            string IE = (string)dest.Element(ns + "IE");

            // 🔹 Percorre produtos
            foreach (var prod in xml.Descendants(ns + "det"))
            {
                var p = prod.Element(ns + "prod");

                dt.Rows.Add(
                    idNFe, cNF, nNF, dhEmi, dhSaiEnt,
                    cnpj, nome, xFant, xLgr, nro, xBairro, xMun, UF, CEP, fone, IE,
                    (string)p.Element(ns + "cProd"),
                    (string)p.Element(ns + "xProd"),
                    (string)p.Element(ns + "qCom"),
                    (string)p.Element(ns + "uCom"),
                    (string)p.Element(ns + "vUnCom"),
                    vLiq
                );
            }

            return dt;
        }


        private DataTable buscaExcel(string pArquivo)
        {
            DataTable dtRetorno = new DataTable();
            List<string> nomeColunas = new List<string> {"INFNFE", "CNF","NNF","DHEMI","DHSAIENT","CNPJ","XNOME","XFANT","XLGR","NRO","XBAIRRO","XMUN","UF","CEP","FONE","IE","CPROD", "XPROD","QCOM", "UCOM", "VUNCOM", "VLIQ" };
            int qtPercorrida = 0;
            bool parada = false;
            List<string> informacoes = new List<string>();

            using (var stream = System.IO.File.Open(pArquivo, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            qtPercorrida++;
                            for (int i = 0; i < 22; i++)
                            {
                                if (qtPercorrida == 1)//VERIFICAR AS COLUNAS
                                {
                                    var teste = reader.GetValue(i);
                                    dtRetorno.Columns.Add(teste.ToString().ToUpper());
                                    if (!nomeColunas.Contains(teste.ToString().ToUpper()))
                                        parada = true;
                                }
                                else //BUSCAR INFORMAÇÕES
                                {
                                    informacoes.Add(reader.GetValue(i).ToString());
                                }

                            }

                            if (qtPercorrida > 1)
                            {
                                DataRow dr = null;
                                dr = dtRetorno.NewRow();
                                for (int j = 0; j < informacoes.Count; j++)
                                {
                                    dr[nomeColunas[j].ToString()] = informacoes[j].ToString();
                                }
                                dtRetorno.Rows.Add(dr);
                                informacoes.Clear();
                            }
                        }
                    } while (reader.NextResult() || parada);

                    // 2. Use the AsDataSet extension method
                    //var result = reader.AsDataSet();

                }
            }

            return dtRetorno;
        }

        private DataTable buscaTudo(string pArquivo)  //METODO PARA RODAR O XML E BUSCAR OS PRODUTOS
        {
            List<string> nomeColunasDesconsiderar = new List<string> { "infNFe", "cNF", "nNF","dhEmi", "dhSaiEnt", "CNPJ","xNome","xFant","xLgr", "nro","xBairro","xMun",
                                                                        "UF","CEP","fone",
                                                                       "IE", "cProd","xProd",
                                                                        "qCom","uCom" , "vUnCom", "vLiq"};
            List<string> nomeColunas = new List<string>();
            List<string> informacoes = new List<string>();

            int countColunas = -1;
            DataTable dtRetorno = new DataTable();
            bool tagNecessaria = false;
            bool tagDestinatario = false;
            bool tagUltima = false;
            string teste = "";
            int qtPercorrida = 0;
            string ultimoValorTag = "";

            XmlTextReader reader = new XmlTextReader(pArquivo);//CLASSE DO VISUAL PARA UTILIZAR XMLs

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:

                        if (nomeColunasDesconsiderar.Contains(reader.Name) && !nomeColunas.Contains(reader.Name.ToUpper()))
                        {
                            nomeColunas.Add(reader.Name.ToUpper());
                            dtRetorno.Columns.Add(reader.Name.ToUpper());
                            countColunas++;
                        }
                        if (reader.Name == "infNFe")
                        {
                            IDNFe = reader.GetAttribute("Id");
                            informacoes.Add(IDNFe);
                        }
                        if (nomeColunasDesconsiderar.Contains(reader.Name) && reader.Name != "infNFe" && !tagDestinatario)
                        {
                            tagNecessaria = true;
                        }
                        if (reader.Name == "dest")
                            tagDestinatario = true;
                        if (reader.Name == "vLiq")
                        {
                            tagUltima = true;
                        }

                        break;
                    case XmlNodeType.Text:
                        //lbDados.Items.Add(reader.Value);
                        //txtDados.Text += reader.Value + Environment.NewLine;
                        if (tagNecessaria && !tagUltima)
                        {
                            informacoes.Add(reader.Value);
                            tagNecessaria = false;
                        }
                        if (tagUltima)
                        {
                            ultimoValorTag = reader.Value;
                            tagUltima = false;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        //lbDados.Items.Add("<" + reader.Name + ">");
                        //txtDados.Text += "<" + reader.Name + ">" + Environment.NewLine;
                        if (reader.Name == "dest")
                        {
                            tagDestinatario = false;
                        }

                        if (reader.Name == "prod")
                        {
                            DataRow dr = null;
                            dr = dtRetorno.NewRow();
                            for (int j = 0; j < informacoes.Count; j++)
                            {
                                //DATAROW[PEGANDO O NOME DA COLUNA] = PEGANDO O VALOR DA COLUNA;
                                if (j == 21)
                                {
                                    for (int k = -5; k < 0; k++)
                                        dr[nomeColunas[j + k]] = informacoes[informacoes.Count + k].ToString();

                                    break;
                                }
                                else
                                {
                                    dr[nomeColunas[j].ToString()] = informacoes[j].ToString();
                                }
                            }
                            qtPercorrida++;
                            dtRetorno.Rows.Add(dr);
                        }
                        break;
                }

            }

            if (dtRetorno.Rows.Count > 0)
            {
                if (dtRetorno.Columns.Contains("VLIQ"))
                {

                    for (int k = 0; k < dtRetorno.Rows.Count; k++)
                    {
                        dtRetorno.Rows[k][dtRetorno.Columns.Count - 1] = ultimoValorTag;
                    }
                }
                else
                {
                    dtRetorno.Columns.Add("VLIQ");
                    double auxVl = 0;
                    for (int k = 0; k < dtRetorno.Rows.Count; k++)
                    {

                        auxVl += double.Parse(dtRetorno.Rows[k]["VUNCOM"].ToString().Replace(".", ",")) * (int)double.Parse(dtRetorno.Rows[k]["QCOM"].ToString().Replace(".", ","));
                        //auxVl += double.Parse(dtRetorno.Rows[k]["VUNCOM"].ToString()) * (int)double.Parse(dtRetorno.Rows[k]["QCOM"].ToString().Replace(".", ","));
                    }

                    for (int k = 0; k < dtRetorno.Rows.Count; k++)
                    {
                        dtRetorno.Rows[k][dtRetorno.Columns.Count-1] = auxVl;
                    }
                }
            }


            return dtRetorno;
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Selecione uma pasta";
                folderDialog.ShowNewFolderButton = true;

                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    string caminhoSelecionado = folderDialog.SelectedPath;
                    txtXML.Text = caminhoSelecionado;
                }
            }
        }
    }
}
