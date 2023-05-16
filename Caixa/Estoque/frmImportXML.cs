using Componentes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

        public frmImportXML()
        {
            InitializeComponent();
        }
        private void BntImportar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtExcel.Text) && !string.IsNullOrEmpty(txtXML.Text))//SE O TXT DO EXCEL E DO XML NAO FOR NULL, ENTAO EXECUTA A TAREFA
            {
                conn = conexao.retornaConexao();
                transacao = conexao.startTransaction(conn);
                StringBuilder sqlSelect = new StringBuilder();
                StringBuilder sqlInsert = new StringBuilder();
                DataTable dt = new DataTable();
                DataTable dtFornecedor = new DataTable();
                string cnpj = "";
                string teste = "";
                try
                {

                    //CRIAR UMA OPCAO PARA NAO SALVAR SE DER ERRO
                    double time = DateTime.Now.TimeOfDay.TotalSeconds;//PEGANDO O HORARIO QUE COMECOU A EXTRACAO EM SEGUNDOS
                    qtArquivos = 0;
                    dtExcelNFe = new DataTable();
                    dtExcelNFe = buscaTudo();
                    SqlCommand sqlComSelect;// = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                    SqlCommand sqlComInsert;
                    //sqlComSelect.CommandType = CommandType.Text;

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
                        if (i == 0)
                        {
                            sqlSelect.Clear();
                            sqlSelect.Append("SELECT * FROM NF WHERE INF_NFE = @pInfNFe");
                            sqlComSelect = new SqlCommand(sqlSelect.ToString(), conn, transacao);
                            sqlComSelect.CommandType = CommandType.Text;
                            sqlComSelect.Parameters.AddWithValue("@pInfNFe", dtExcelNFe.Rows[i]["INFNFE"].ToString());
                            dt = auxSQL.retornaDataTableTransaction(conn, sqlComSelect);
                        }

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
                            sqlComInsert.Parameters.AddWithValue("@VALOR", dtExcelNFe.Rows[i]["vLiq"].ToString());
                            auxSQL.executaQueryTransaction(conn, sqlComInsert);

                            //PERCORRER TODOS OS PRODUTOS PARA INSERIR ELES
                            for (int j = i; true; j++)
                            {
                                if (dtExcelNFe.Rows.Count > j && dtExcelNFe.Rows[i]["INFNFE"].ToString().Equals(dtExcelNFe.Rows[j]["INFNFE"].ToString()))
                                {
                                    //INSERINDO O PRODUTO DA NF NO SISTEMA
                                    sqlInsert.Clear();
                                    sqlInsert.Append("INSERT INTO NF_PROD(NF, COD_PROD, DESC_PROD, QT_COM, VL_UNIT) ");
                                    sqlInsert.Append("VALUES ((SELECT ID FROM NF WHERE INF_NFE = @INF_NFE),@COD_PROD, @DESC_PROD, @QT_COM, @VL_UNIT )  ");
                                    sqlComInsert = new SqlCommand(sqlInsert.ToString(), conn, transacao);
                                    sqlComInsert.Parameters.AddWithValue("@INF_NFE", dtExcelNFe.Rows[j]["infNFe"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@COD_PROD", dtExcelNFe.Rows[j]["cProd"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@DESC_PROD", dtExcelNFe.Rows[j]["xProd"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@QT_COM", dtExcelNFe.Rows[j]["qCom"].ToString());
                                    sqlComInsert.Parameters.AddWithValue("@VL_UNIT", dtExcelNFe.Rows[j]["vUnCom"].ToString());
                                    auxSQL.executaQueryTransaction(conn, sqlComInsert);
                                }
                                else
                                {
                                    i = j - 1;
                                    break;
                                }
                            }

                        }

                    }

                    insertProduto();

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
                }      //FECHANDO TODAS AS INFORMACOES DO COMPONENTE BACKGROUNDWORKER 
            }
            else
            {
                MessageBox.Show("Por favor, informe os caminhos corretos.");
            }
        }

        private DataTable buscaTudo()  //METODO PARA RODAR O XML E BUSCAR OS PRODUTOS
        {
            List<string> nomeColunasDesconsiderar = new List<string> { "infNFe", "cNF", "nNF","dhEmi", "dhSaiEnt", "CNPJ","xNome","xFant","xLgr", "nro","xBairro","xMun",
                                                                        "UF","CEP","fone",
                                                                       "IE", "cProd","xProd",
                                                                        "qCom", "vUnCom", "vLiq"};
            List<string> nomeColunas = new List<string>();
            nomeArquivos = new List<string>();
            arquivos = new List<string>();
            List<string> informacoes = new List<string>();

            arquivos.AddRange(Directory.GetFiles(txtXML.Text));//PEGANDO TODOS OS ARQUIVOS NO CAMINHO DO XML           
            int countColunas = -1;
            DataTable dtRetorno = new DataTable();
            bool tagNecessaria = false;
            bool tagDestinatario = false;
            bool tagUltima = false;
            string teste = "";
            int qtPercorrida = 0;
            string ultimoValorTag = "";

            for (int i = 0; i < arquivos.Count(); i++)//LACO PARA EXECUTAR TODOS OS ARQUIVOS, MESMO SENDO XML OU NAO
            {
                if (arquivos[i].ToUpper().Contains(".XML"))//APENAS XMLs
                {
                    qtArquivos++;//VARIAVEL UTILIZADA PARA MOSTRAR A QUANTIDADE DE ARQUIVOS QUE FOI PROCESSADO NO FIM
                    XmlTextReader reader = new XmlTextReader(arquivos[i]);//CLASSE DO VISUAL PARA UTILIZAR XMLs
                    nomeArquivos.Add(arquivos[i]);

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
                                        if (j == 20)
                                        {
                                            for (int k = -4; k < 0; k++)
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
                }
            }

            for (int k = 0; k < dtRetorno.Rows.Count; k++)
                dtRetorno.Rows[k][dtRetorno.Columns.Count - 1] = ultimoValorTag;


            return dtRetorno;
        }

        private void insertNF()
        {

        }
        private void insertFornecedor()
        {

        }
        private void insertProduto()
        {

        }
    }
}
