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
        private List<string> arquivosDeletar;
        private string msgErro;
        private DataTable dtExcelFornecedores;
        private DataTable dtExcelProdutos;
        private DataTable dtExcelNFe;
        private int qtArquivos = 0;
        private int qtArquivosSemErro = 0;
        private List<string> nomeArquivos;
        private List<string> codigoCNPJ;
        private List<string> dataRecebimento;
        private SqlConnection conn;
        private SqlTransaction transacao;
        private dal.Conexao conexao = new dal.Conexao();
        DataTable dtRetornoAux = new DataTable();
        private string IDNFe;

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
                try
                {

                    //CRIAR UMA OPCAO PARA NAO SALVAR SE DER ERRO
                    double time = DateTime.Now.TimeOfDay.TotalSeconds;//PEGANDO O HORARIO QUE COMECOU A EXTRACAO EM SEGUNDOS
                    qtArquivos = 0;
                    dtExcelNFe = new DataTable();
                    dtExcelNFe = buscaTudo();


                }
                catch (Exception er)
                {
                    transacao.Rollback();
                    conn.Close();
                    MessageBox.Show("Erro: " + er.InnerException.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private DataTable rodaFornecedorXML(string pTagXML, string pTagChave)   //METODO PARA RODAR O XML E BUSCAR OS PRODUTOS
        {
            List<string> nomeColunas = new List<string>();
            nomeArquivos = new List<string>();
            codigoCNPJ = new List<string>();
            dataRecebimento = new List<string>();
            arquivos = new List<string>();
            arquivosDeletar = new List<string>();

            arquivos.AddRange(Directory.GetFiles(txtXML.Text));//PEGANDO TODOS OS ARQUIVOS NO CAMINHO DO XML           
            ArrayList elementos = new ArrayList();
            int countColunas = -1;
            DataTable dtRetorno = new DataTable();
            string diretorio = txtXML.Text;
            List<int> removePosicao = new List<int>();
            msgErro = "";

            for (int i = 0; i < arquivos.Count(); i++)//LACO PARA EXECUTAR TODOS OS ARQUIVOS, MESMO SENDO XML OU NAO
            {
                if (arquivos[i].ToUpper().Contains(".XML"))//APENAS XMLs
                {
                    try
                    {
                        qtArquivos++;//VARIAVEL UTILIZADA PARA MOSTRAR A QUANTIDADE DE ARQUIVOS QUE FOI PROCESSADO NO FIM
                        XmlTextReader reader = new XmlTextReader(arquivos[i]);//CLASSE DO VISUAL PARA UTILIZAR XMLs
                        nomeArquivos.Add(arquivos[i]);
                        while ((reader.Read()))//BUSCANDO O XML TAG POR TAG
                        {
                            if (reader.Name.ToUpper().Equals(pTagXML))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO  ESTOU NO INICIO DO PROD
                            {
                                while ((reader.Read()))
                                {

                                    if (reader.Name.ToUpper().Equals(pTagXML))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO ESTOU NO FIM DO PROD
                                        break;

                                    if (!string.IsNullOrEmpty(reader.Name) && !nomeColunas.Contains(reader.Name.ToUpper()))// && !nomeColunas.Contains(reader.Name.ToUpperInvariant()))
                                    {
                                        nomeColunas.Add(reader.Name.ToUpper());
                                        countColunas++;
                                    }
                                }
                            }
                        }
                        qtArquivosSemErro++;
                    }
                    catch
                    {
                        removePosicao.Add(i);
                        msgErro += arquivos[i].Substring(arquivos[i].LastIndexOf('\\') + 1) + " \n";
                        arquivosDeletar.Add(arquivos[i]);
                        nomeArquivos.RemoveAt(nomeArquivos.Count() - 1);
                    }
                }
            }

            for (int i = removePosicao.Count() - 1; i > -1; i--)
                arquivos.RemoveAt(removePosicao[i]);


            List<string> teste = new List<string>();
            List<string> teste2 = new List<string>();
            string nomeColunaTeste = "";
            bool condicao;
            for (int i = 0; i < arquivos.Count(); i++)//LACO PARA EXECUTAR TODOS OS ARQUIVOS, MESMO SENDO XML OU NAO
            {
                if (arquivos[i].ToUpper().Contains(".XML"))//APENAS XMLs
                {
                    XmlTextReader reader = new XmlTextReader(arquivos[i]);//CLASSE DO VISUAL PARA UTILIZAR XMLs
                    condicao = true;
                    while ((reader.Read()))//BUSCANDO O XML TAG POR TAG
                    {
                        if (reader.Name.ToUpper().Equals(pTagXML))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO  ESTOU NO INICIO DO PROD
                        {
                            int cont = -1;
                            while ((reader.Read()))
                            {
                                cont++;
                                if (!string.IsNullOrEmpty(reader.Name) && nomeColunas.Contains(reader.Name.ToUpper()))
                                {
                                    nomeColunaTeste = reader.Name.ToUpper();
                                    cont = 0;
                                }

                                if (reader.Name.ToUpper().Equals(pTagXML))
                                    break;

                                switch (reader.NodeType)
                                {
                                    case XmlNodeType.Element:
                                        //SE EXISTIREM ATRIBUTOS
                                        if (reader.HasAttributes)
                                        {
                                            while (reader.MoveToNextAttribute())
                                            {
                                                //PEGA O VALOR DO ATRIBUTO
                                                //elementos.Add(nomeColunas[countCampos] + "#@#" + reader.Value);//INCLUIR O TEXTO DE ELEMENTOS NA LISTA DE ELEMENTOS, SEGUIDOS POR NOME_COLUNA #@# E VALOR_CAMPO
                                                teste.Add(reader.Value);
                                                //if (nomeColunaTeste.ToUpper().Equals("CNPJ"))
                                                //codigoCNPJ.Add(reader.Value);
                                                if (reader.Name.ToUpper().Equals(pTagXML))
                                                    break;
                                            }
                                        }
                                        break;
                                    case XmlNodeType.Text:

                                        //elementos.Add(nomeColunas[countCampos] + "#@#" + reader.Value);//INCLUIR O TEXTO DE ELEMENTOS NA LISTA DE ELEMENTOS, SEGUIDOS POR NOME_COLUNA #@# E VALOR_CAMPO
                                        if (nomeColunas.Contains(nomeColunaTeste) && cont == 1)
                                        {
                                            elementos.Add(nomeColunaTeste + "#@#" + reader.Value);//INCLUIR O TEXTO DE ELEMENTOS NA LISTA DE ELEMENTOS, SEGUIDOS POR NOME_COLUNA #@# E VALOR_CAMPO
                                            if (nomeColunaTeste.ToUpper().Equals("CNPJ"))
                                            {
                                                codigoCNPJ.Add(reader.Value);
                                                condicao = false;
                                            }

                                            if (reader.Name.ToUpper().Equals(pTagXML))
                                                break;
                                        }

                                        break;
                                    case XmlNodeType.CDATA:
                                        //SE EXISTIREM ATRIBUTOS
                                        if (nomeColunas.Contains(nomeColunaTeste) && cont == 1)
                                        {
                                            elementos.Add(nomeColunaTeste + "#@#" + reader.Value);//INCLUIR O TEXTO DE ELEMENTOS NA LISTA DE ELEMENTOS, SEGUIDOS POR NOME_COLUNA #@# E VALOR_CAMPO
                                            if (nomeColunaTeste.ToUpper().Equals("CNPJ"))
                                                codigoCNPJ.Add(reader.Value);
                                            if (reader.Name.ToUpper().Equals(pTagXML))
                                                break;
                                        }

                                        break;
                                }
                            }
                        }
                    }
                    if (condicao)
                        codigoCNPJ.Add(" ");
                }
            }


            for (int i = 0; i < nomeArquivos.Count; i++)
            {
                condicao = true;
                XmlTextReader reader = new XmlTextReader(nomeArquivos[i]);//CLASSE DO VISUAL PARA UTILIZAR XMLs
                while ((reader.Read()))//BUSCANDO O XML TAG POR TAG
                {
                    if (reader.Name.ToUpper().Equals("dhRecbto".ToUpper()))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO  ESTOU NO INICIO DO PROD
                    {
                        reader.Read();
                        dataRecebimento.Add(DateTime.Parse(reader.Value.ToString().Replace("T", " ").Replace("t", " ").Substring(0, 19)).ToString());
                        condicao = false;
                        break;
                    }
                }

                if (condicao)
                    dataRecebimento.Add(" ");
            }

            //SE A QUANTIDADE DE COLUNAS FOR MAIOR QUE 0, ENTAO EU ADICIONO MINHAS COLUNAS NO MEU DATATABLE
            if (nomeColunas.Count > 0)
            {
                for (int i = 0; i < nomeColunas.Count; i++)
                {
                    if (!dtRetorno.Columns.Contains(nomeColunas[i]) && !string.IsNullOrEmpty(nomeColunas[i]))
                    {
                        dtRetorno.Columns.Add(nomeColunas[i].ToUpper());
                    }
                }

                DataRow dr = null;
                int qtRegistros = -1;
                for (int i = 0; i < elementos.Count; i++)
                {
                    //if (elementos[i].ToString().ToUpper().Contains(pTagChave))
                    //{
                        if (qtRegistros > -1)
                            dtRetorno.Rows.Add(dr);

                        qtRegistros++;
                        dr = dtRetorno.NewRow();
                    //}
                    //DATAROW[PEGANDO O NOME DA COLUNA] = PEGANDO O VALOR DA COLUNA;
                    dr[elementos[i].ToString().Substring(0, elementos[i].ToString().IndexOf("#@#"))] = elementos[i].ToString().Substring(elementos[i].ToString().IndexOf("#@#") + 3).ToUpper();
                }

                dtRetorno.Rows.Add(dr);//ADICIONANDO MINHA DATAROW EM MINHA DATATABLE
            }

            return dtRetorno;
        }
        private DataTable rodaProdutoXML(string pTagXML, string pTagChave)   //METODO PARA RODAR O XML E BUSCAR OS PRODUTOS
        {
            List<string> nomeColunas = new List<string>();
            List<string> auxNomeColunas = new List<string>();
            List<string> nomeColunasDesconsiderar = new List<string> { "ICMS40", "ICMS51", "ICMSSN500","ICMS10", "ICMS20", "ICMS00","ICMS60","ICMS90","ICMSSN202", "ICMSSN900","ICMSSN102","ICMSSN101",
                                                                        "PISNT","PISOUTR","PISALIQ",
                                                                       "COFINSNT", "COFINSOUTR","COFINSALIQ",
                                                                        "IPINT", "IPITRIB", "VIPIDEVOL"};
            //arquivos.AddRange(Directory.GetFiles(txtXML.Text));//PEGANDO TODOS OS ARQUIVOS NO CAMINHO DO XML
            ArrayList elementos = new ArrayList();
            int countColunas = -1;
            DataTable dtRetorno = new DataTable();
            int colPrincipal = 1000, colImposto1 = 1100, colImposto2 = 1200, colImposto3 = 1300, colImposto4 = 1400;
            int qtColImpostos = 0;
            List<string> tagsRepetidas = new List<string>();

            for (int i = 0; i < arquivos.Count(); i++)//LACO PARA EXECUTAR TODOS OS ARQUIVOS, MESMO SENDO XML OU NAO
            {
                if (arquivos[i].ToUpper().Contains(".XML"))//APENAS XMLs
                {
                    XmlTextReader reader = new XmlTextReader(arquivos[i]);//CLASSE DO VISUAL PARA UTILIZAR XMLs
                    while (reader.Read() && !reader.Name.ToUpper().Equals("TOTAL"))//BUSCANDO O XML TAG POR TAG
                    {
                        if (reader.Name.ToUpper().Equals(pTagXML))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO  ESTOU NO INICIO DO PROD
                        {
                            while ((reader.Read()))
                            {

                                if (reader.Name.ToUpper().Equals(pTagXML))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO ESTOU NO FIM DO PROD
                                    break;

                                if (!string.IsNullOrEmpty(reader.Name) && !auxNomeColunas.Contains(reader.Name.ToUpper()))// && !nomeColunas.Contains(reader.Name.ToUpperInvariant()))
                                {
                                    auxNomeColunas.Add(reader.Name.ToUpper());
                                    colPrincipal++;
                                    nomeColunas.Add(colPrincipal + reader.Name.ToUpper());
                                    countColunas++;
                                }
                            }
                        }

                        //TAGS DE IMPOSTOS
                        if (reader.Name.ToUpper().Equals("ICMS"))
                        {
                            while ((reader.Read()))
                            {

                                if (reader.Name.ToUpper().Equals("ICMS"))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO ESTOU NO FIM DO PROD
                                    break;

                                if (!string.IsNullOrEmpty(reader.Name) && !nomeColunasDesconsiderar.Contains(reader.Name.ToUpper()) && !auxNomeColunas.Contains("ICMS_" + reader.Name.ToUpper()))// && !nomeColunas.Contains(reader.Name.ToUpperInvariant()))
                                {
                                    auxNomeColunas.Add("ICMS_" + reader.Name.ToUpper());
                                    colImposto1++;
                                    nomeColunas.Add(colImposto1 + "ICMS_" + reader.Name.ToUpper());
                                    countColunas++;
                                    qtColImpostos++;
                                }
                            }
                        }


                        if (reader.Name.ToUpper().Equals("PIS"))
                        {
                            while ((reader.Read()))
                            {

                                if (reader.Name.ToUpper().Equals("PIS"))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO ESTOU NO FIM DO PROD
                                    break;

                                if (!string.IsNullOrEmpty(reader.Name) && !nomeColunasDesconsiderar.Contains(reader.Name.ToUpper()) && !auxNomeColunas.Contains("PIS_" + reader.Name.ToUpper()))// && !nomeColunas.Contains(reader.Name.ToUpperInvariant()))
                                {
                                    auxNomeColunas.Add("PIS_" + reader.Name.ToUpper());
                                    colImposto2++;
                                    nomeColunas.Add(colImposto2 + "PIS_" + reader.Name.ToUpper());
                                    countColunas++;
                                    qtColImpostos++;
                                }
                            }
                        }

                        if (reader.Name.ToUpper().Equals("COFINS"))
                        {
                            while ((reader.Read()))
                            {

                                if (reader.Name.ToUpper().Equals("COFINS"))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO ESTOU NO FIM DO PROD
                                    break;

                                if (!string.IsNullOrEmpty(reader.Name) && !nomeColunasDesconsiderar.Contains(reader.Name.ToUpper()) && !auxNomeColunas.Contains("COFINS_" + reader.Name.ToUpper()))// && !nomeColunas.Contains(reader.Name.ToUpperInvariant()))
                                {
                                    auxNomeColunas.Add("COFINS_" + reader.Name.ToUpper());
                                    colImposto3++;
                                    nomeColunas.Add(colImposto3 + "COFINS_" + reader.Name.ToUpper());
                                    countColunas++;
                                    qtColImpostos++;
                                }
                            }
                        }

                        if (reader.Name.ToUpper().Equals("IPI"))
                        {
                            while ((reader.Read()))
                            {

                                if (reader.Name.ToUpper().Equals("IPI"))//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO ESTOU NO FIM DO PROD
                                    break;

                                if (!string.IsNullOrEmpty(reader.Name) && !nomeColunasDesconsiderar.Contains(reader.Name.ToUpper()) && !auxNomeColunas.Contains("IPI_" + reader.Name.ToUpper()))// && !nomeColunas.Contains(reader.Name.ToUpperInvariant()))
                                {
                                    auxNomeColunas.Add("IPI_" + reader.Name.ToUpper());
                                    colImposto4++;
                                    nomeColunas.Add(colImposto4 + "IPI_" + reader.Name.ToUpper());
                                    countColunas++;
                                    qtColImpostos++;

                                    //if (reader.Name.ToUpper().Equals("CST"))
                                    //{
                                    //    string testeXML = reader.BaseURI.ToString();
                                    //}
                                }
                            }
                        }
                    }
                }
            }

            nomeColunas.Sort();
            for (int i = 0; i < nomeColunas.Count; i++)
                nomeColunas[i] = nomeColunas[i].Substring(4);

            List<string> teste = new List<string>();
            List<string> teste2 = new List<string>();
            string nomeColunaTeste = "";
            bool auxImpostoICMS = false, auxImpostoIPI = false, auxImpostoPIS = false, auxImpostoCOFINS = false;
            for (int i = 0; i < arquivos.Count(); i++)//LACO PARA EXECUTAR TODOS OS ARQUIVOS, MESMO SENDO XML OU NAO
            {
                if (arquivos[i].ToUpper().Contains(".XML"))//APENAS XMLs
                {

                    int cont = -1;
                    XmlTextReader reader = new XmlTextReader(arquivos[i]);//CLASSE DO VISUAL PARA UTILIZAR XMLs
                    while ((reader.Read()))//BUSCANDO O XML TAG POR TAG
                    {
                        if (reader.Name.ToUpper().Equals(pTagXML))// || reader.Name.ToUpper().Equals("ICMS")))// && auxImposto)// && auxImposto2 && auxImposto3)//SE A TAG QUE FOI PASSADO COMO PARAMETRO NESSE METODO FOR IGUAL A TAG DA LINHA DO XML, ENTAO  ESTOU NO INICIO DO PROD
                        {
                            //int cont = -1;
                            while ((reader.Read()))
                            {
                                switch (reader.Name)
                                {
                                    case "ICMS":
                                        auxImpostoICMS = !auxImpostoICMS;
                                        auxImpostoIPI = false;
                                        auxImpostoPIS = false;
                                        auxImpostoCOFINS = false;
                                        break;

                                    case "IPI":
                                        auxImpostoICMS = false;
                                        auxImpostoIPI = !auxImpostoIPI;
                                        auxImpostoPIS = false;
                                        auxImpostoCOFINS = false;
                                        break;

                                    case "COFINS":
                                        auxImpostoICMS = false;
                                        auxImpostoIPI = false;
                                        auxImpostoCOFINS = !auxImpostoCOFINS;
                                        auxImpostoPIS = false;
                                        break;

                                    case "PIS":
                                        auxImpostoICMS = false;
                                        auxImpostoIPI = false;
                                        auxImpostoCOFINS = false;
                                        auxImpostoPIS = !auxImpostoPIS;
                                        break;
                                }

                                cont++;
                                if (!string.IsNullOrEmpty(reader.Name) &&
                                        (nomeColunas.Contains(reader.Name.ToUpper()) ||
                                        nomeColunas.Contains("ICMS_" + reader.Name.ToUpper()) ||
                                        nomeColunas.Contains("PIS_" + reader.Name.ToUpper()) ||
                                        nomeColunas.Contains("COFINS_" + reader.Name.ToUpper()) ||
                                        nomeColunas.Contains("IPI_" + reader.Name.ToUpper())
                                        ))
                                {
                                    if (nomeColunas.Contains("ICMS_" + reader.Name.ToUpper()) && auxImpostoICMS)
                                        nomeColunaTeste = "ICMS_" + reader.Name.ToUpper();
                                    else if (nomeColunas.Contains("PIS_" + reader.Name.ToUpper()) && auxImpostoPIS)
                                        nomeColunaTeste = "PIS_" + reader.Name.ToUpper();
                                    else if (nomeColunas.Contains("COFINS_" + reader.Name.ToUpper()) && auxImpostoCOFINS)
                                        nomeColunaTeste = "COFINS_" + reader.Name.ToUpper();
                                    else if (nomeColunas.Contains("IPI_" + reader.Name.ToUpper()) && auxImpostoIPI)
                                        nomeColunaTeste = "IPI_" + reader.Name.ToUpper();
                                    else
                                        nomeColunaTeste = reader.Name.ToUpper();

                                    cont = 0;
                                }


                                /*
                                if (nomeColunaTeste.ToUpper().Contains("ICMS_PREDBCST"))
                                {
                                    string testeXML = reader.BaseURI.ToString().Substring(reader.BaseURI.ToString().LastIndexOf("/")+1);
                                }*/

                                switch (reader.NodeType)
                                {
                                    case XmlNodeType.Element:
                                        //SE EXISTIREM ATRIBUTOS
                                        if (reader.HasAttributes)
                                        {
                                            while (reader.MoveToNextAttribute())
                                            {
                                                //PEGA O VALOR DO ATRIBUTO
                                                //elementos.Add(nomeColunas[countCampos] + "#@#" + reader.Value);//INCLUIR O TEXTO DE ELEMENTOS NA LISTA DE ELEMENTOS, SEGUIDOS POR NOME_COLUNA #@# E VALOR_CAMPO
                                                //teste.Add(reader.Value);

                                                if (nomeArquivos.Contains(arquivos[i]))
                                                {
                                                    int posicao = 0;
                                                    while (!nomeArquivos[posicao].Equals(arquivos[i]))
                                                    {
                                                        posicao++;
                                                    }
                                                    elementos.Add("CNPJ#@#" + codigoCNPJ[posicao]);
                                                    elementos.Add("DT_RECEBIMENTO#@#" + dataRecebimento[posicao]);
                                                }


                                            }
                                        }
                                        break;
                                    case XmlNodeType.Text:

                                        //elementos.Add(nomeColunas[countCampos] + "#@#" + reader.Value);//INCLUIR O TEXTO DE ELEMENTOS NA LISTA DE ELEMENTOS, SEGUIDOS POR NOME_COLUNA #@# E VALOR_CAMPO
                                        if (nomeColunas.Contains(nomeColunaTeste) && cont == 1)
                                        {
                                            //if (elementos.Contains("CPROD#@#" + reader.Value))
                                            //{
                                            //    fimXML = false;
                                            //    break;
                                            //}

                                            //if (nomeColunaTeste.Contains("IPI"))
                                            //{
                                            //    string testeXML = reader.BaseURI.ToString();
                                            //}
                                            if (nomeColunaTeste.Equals("CPROD") && reader.Value.Contains("3101"))
                                            {
                                                string testeXML = reader.BaseURI.ToString().Substring(reader.BaseURI.ToString().LastIndexOf("/") + 1);
                                            }

                                            elementos.Add(nomeColunaTeste + "#@#" + reader.Value);//INCLUIR O TEXTO DE ELEMENTOS NA LISTA DE ELEMENTOS, SEGUIDOS POR NOME_COLUNA #@# E VALOR_CAMPO
                                            if (nomeColunaTeste.Contains("CPROD") && nomeArquivos.Contains(arquivos[i]))
                                            {
                                                int posicao = 0;
                                                while (!nomeArquivos[posicao].Equals(arquivos[i]))
                                                {
                                                    posicao++;
                                                }
                                                elementos.Add("CNPJ#@#" + codigoCNPJ[posicao]);
                                                elementos.Add("DT_RECEBIMENTO#@#" + dataRecebimento[posicao]);
                                            }
                                        }

                                        break;
                                }
                            }
                        }
                    }
                }
            }

            //SE A QUANTIDADE DE COLUNAS FOR MAIOR QUE 0, ENTAO EU ADICIONO MINHAS COLUNAS NO MEU DATATABLE
            if (nomeColunas.Count > 0)
            {
                dtRetornoAux = new DataTable();
                for (int i = 0; i < nomeColunas.Count; i++)
                {
                    if (!dtRetorno.Columns.Contains(nomeColunas[i]) && !string.IsNullOrEmpty(nomeColunas[i]))
                    {
                        dtRetorno.Columns.Add(nomeColunas[i].ToUpper());
                        dtRetornoAux.Columns.Add(nomeColunas[i].ToUpper());
                        if (i == 0)
                        {
                            dtRetorno.Columns.Add("CNPJ");
                            dtRetorno.Columns.Add("DT_RECEBIMENTO");
                            dtRetornoAux.Columns.Add("CNPJ");
                            dtRetornoAux.Columns.Add("DT_RECEBIMENTO");
                        }
                    }
                }

                DataRow dr = null;
                int qtRegistros = -1;
                for (int i = 0; i < elementos.Count; i++)
                {
                    if (elementos[i].ToString().ToUpper().Contains(pTagChave))
                    {
                        if (qtRegistros > -1)
                            dtRetorno.Rows.Add(dr);

                        qtRegistros++;
                        dr = dtRetorno.NewRow();
                    }

                    //DATAROW[PEGANDO O NOME DA COLUNA] = PEGANDO O VALOR DA COLUNA;
                    dr[elementos[i].ToString().Substring(0, elementos[i].ToString().IndexOf("#@#"))] = elementos[i].ToString().Substring(elementos[i].ToString().IndexOf("#@#") + 3).ToUpper();
                }

                dtRetorno.Rows.Add(dr);
            }

            List<int> removerLinhasNull = new List<int>();

            DataRow[] dr2 = dtRetorno.Select("", "CNPJ, CPROD, DT_RECEBIMENTO " + " DESC");//ORDENANDO A TABELA ATRAVES DAS COLUNAS PRINCIPAIS EM ORDEM DECRESCENTE
            DataTable dtRetornoAux2 = dr2.CopyToDataTable();

            bool auxRemocao = false;

            for (int i = 0; i < dtRetornoAux2.Rows.Count - 1; i++)
            {
                if (string.IsNullOrEmpty(dtRetornoAux2.Rows[i]["CPROD"].ToString()) || string.IsNullOrEmpty(dtRetornoAux2.Rows[i]["CNPJ"].ToString()))
                    removerLinhasNull.Add(i);

                if (!string.IsNullOrEmpty(dtRetornoAux2.Rows[i]["CPROD"].ToString().Trim()) && !string.IsNullOrEmpty(dtRetornoAux2.Rows[i + 1]["CPROD"].ToString().Trim()) &&
                    !string.IsNullOrEmpty(dtRetornoAux2.Rows[i]["CNPJ"].ToString().Trim()) && !string.IsNullOrEmpty(dtRetornoAux2.Rows[i + 1]["CNPJ"].ToString().Trim()) &&
                    dtRetornoAux2.Rows[i]["CPROD"].ToString().Trim().Equals(dtRetornoAux2.Rows[i + 1]["CPROD"].ToString().Trim()) &&
                    dtRetornoAux2.Rows[i]["CNPJ"].ToString().Trim().Equals(dtRetornoAux2.Rows[i + 1]["CNPJ"].ToString().Trim()))
                {
                    auxRemocao = false;
                    for (int j = dtRetornoAux2.Columns.Count - 1; j > dtRetornoAux2.Columns.Count - qtColImpostos; j--)
                    {
                        if (!dtRetornoAux2.Rows[i][j].Equals(dtRetornoAux2.Rows[i + 1][j]))
                        {
                            auxRemocao = true;
                            break;
                        }
                    }

                    if (!auxRemocao)
                    {
                        removerLinhasNull.Add(i);
                    }
                }

            }

            removerLinhasNull.Sort();
            for (int i = removerLinhasNull.Count; i > 0; i--)
            {
                dtRetornoAux2.Rows.RemoveAt(removerLinhasNull[i - 1]);
            }


            return dtRetornoAux2;
        }

        private DataTable removeDuplicados(DataTable pDt, string pOrder, int pTipo)//TIPO 1 = FORNECEDORES, 2 = PRODUTOS;
        {
            DataTable dtRetorno = new DataTable();
            DataRow dtRow;
            List<int> linhasDeletas = new List<int>();
            DataRow[] dr = pDt.Select("", pOrder + " desc");//ORDENANDO A TABELA ATRAVES DAS COLUNAS PRINCIPAIS EM ORDEM DECRESCENTE
            dtRetorno = dr.CopyToDataTable();

            List<string> chaves = new List<string>();
            List<string> chaves2 = new List<string>();
            //PEGANDO AS POSICOES DUPLICADAS DA TABELA
            for (int i = 0; i < dtRetorno.Rows.Count; i++)
            {
                if ((!chaves.Contains(dtRetorno.Rows[i][0].ToString()) || (chaves.Contains(dtRetorno.Rows[i][0].ToString()) && !chaves2.Contains(dtRetorno.Rows[i][1].ToString()))) && pTipo == 2)
                {
                    chaves.Add(dtRetorno.Rows[i][0].ToString());
                    chaves2.Add(dtRetorno.Rows[i][1].ToString());
                    for (int j = 0; j < chaves.Count - 1; j++)
                    {
                        if (!chaves[j].Equals(chaves[j + 1]))
                        {
                            chaves.Clear();
                            chaves2.Clear();
                        }
                    }
                }
                if (/*(!chaves.Contains(dtRetorno.Rows[i][0].ToString()) || (chaves.Contains(dtRetorno.Rows[i][0].ToString()) && !chaves2.Contains(dtRetorno.Rows[i][1].ToString()))) && */pTipo == 3)
                {
                    //chaves.Add(dtRetorno.Rows[i][0].ToString());
                    //chaves2.Add(dtRetorno.Rows[i][1].ToString());
                    //for (int j = 0; j < chaves.Count - 1; j++)
                    //{
                    //    if (!chaves[j].Equals(chaves[j + 1]))
                    //    {
                    //        chaves.Clear();
                    //        chaves2.Clear();
                    //        linhasDeletas.Add(i);
                    //    }
                    //}
                    bool condicao = true;
                    dtRow = dtRetornoAux.NewRow();
                    for (int k = 0; k < dtRetorno.Columns.Count; k++)
                    {
                        dtRow[k] = dtRetorno.Rows[i][k].ToString();
                    }
                    for (int j = 0; j < dtRetornoAux.Rows.Count; j++)
                    {
                        if (dtRetornoAux.Rows[j][0].ToString().ToUpper().Equals(dtRow[0].ToString().ToUpper()) && dtRetornoAux.Rows[j][1].ToString().ToUpper().Equals(dtRow[1].ToString().ToUpper()))
                        {
                            condicao = false;
                            break;
                        }
                    }

                    if (condicao)
                        dtRetornoAux.Rows.Add(dtRow);
                    else
                        linhasDeletas.Add(i);
                }
                else if (!chaves.Contains(dtRetorno.Rows[i][0].ToString()) && pTipo == 1)
                {
                    chaves.Add(dtRetorno.Rows[i][0].ToString());
                }
                else
                {
                    linhasDeletas.Add(i);
                }
            }

            //REMOVENDO AS LINHAS DUPLICADAS DA TABELA
            while (linhasDeletas.Count > 0)
            {
                dtRetorno.Rows.RemoveAt(linhasDeletas[linhasDeletas.Count - 1]);
                linhasDeletas.RemoveAt(linhasDeletas.Count - 1);
            }

            if (pTipo == 3)
                return dtRetornoAux;
            else
                return dtRetorno;
        }

    }
}
