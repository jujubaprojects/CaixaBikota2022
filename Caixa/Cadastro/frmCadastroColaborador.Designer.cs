namespace Caixa.Cadastro
{
    partial class frmCadastroColaborador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvColaboradores = new Componentes.DataGridViewJCS(this.components);
            this.labelJCS1 = new Componentes.LabelJCS(this.components);
            this.txtID = new Componentes.TextBoxJCS(this.components);
            this.txtNome = new Componentes.TextBoxJCS(this.components);
            this.labelJCS2 = new Componentes.LabelJCS(this.components);
            this.dtpNascimento = new Componentes.dateTimePickerJCS(this.components);
            this.dtpSaida = new Componentes.dateTimePickerJCS(this.components);
            this.labelJCS3 = new Componentes.LabelJCS(this.components);
            this.labelJCS4 = new Componentes.LabelJCS(this.components);
            this.cboStatus = new Componentes.ComboBoxJCS(this.components);
            this.labelJCS5 = new Componentes.LabelJCS(this.components);
            this.txtLogradouro = new Componentes.TextBoxJCS(this.components);
            this.ttxNumero = new Componentes.TextBoxJCS(this.components);
            this.txtBairro = new Componentes.TextBoxJCS(this.components);
            this.txtCidade = new Componentes.TextBoxJCS(this.components);
            this.txtEstado = new Componentes.TextBoxJCS(this.components);
            this.labelJCS6 = new Componentes.LabelJCS(this.components);
            this.txtContato = new Componentes.TextBoxJCS(this.components);
            this.txtEmail = new Componentes.TextBoxJCS(this.components);
            this.dtpInicio = new Componentes.dateTimePickerJCS(this.components);
            this.labelJCS7 = new Componentes.LabelJCS(this.components);
            this.labelJCS8 = new Componentes.LabelJCS(this.components);
            this.txtSalario = new Componentes.TextBoxJCS(this.components);
            this.txtBeneficios = new Componentes.TextBoxJCS(this.components);
            this.labelJCS9 = new Componentes.LabelJCS(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeneficios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCPF = new Componentes.TextBoxJCS(this.components);
            this.labelJCS10 = new Componentes.LabelJCS(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.AllowUserToDeleteRows = false;
            this.dgvColaboradores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvColaboradores.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColaboradores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colRua,
            this.colNumero,
            this.colBairro,
            this.colCidade,
            this.Estado,
            this.colContato,
            this.colEmail,
            this.colDataNascimento,
            this.colDtInicio,
            this.colDtSaida,
            this.colSalario,
            this.colBeneficios,
            this.colStatus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColaboradores.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvColaboradores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvColaboradores.EnableHeadersVisualStyles = false;
            this.dgvColaboradores.Location = new System.Drawing.Point(0, 199);
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvColaboradores.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvColaboradores.RowHeadersVisible = false;
            this.dgvColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColaboradores.Size = new System.Drawing.Size(800, 251);
            this.dgvColaboradores.TabIndex = 15;
            // 
            // labelJCS1
            // 
            this.labelJCS1.AutoSize = true;
            this.labelJCS1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS1.Location = new System.Drawing.Point(12, 45);
            this.labelJCS1.Name = "labelJCS1";
            this.labelJCS1.Size = new System.Drawing.Size(86, 17);
            this.labelJCS1.TabIndex = 16;
            this.labelJCS1.Text = "Colaborador:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtID.IconeKeyDown = null;
            this.txtID.Location = new System.Drawing.Point(104, 42);
            this.txtID.Name = "txtID";
            this.txtID.Preenchimento = null;
            this.txtID.Size = new System.Drawing.Size(50, 24);
            this.txtID.TabIndex = 17;
            this.txtID.TipoCampo = null;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtNome.IconeKeyDown = null;
            this.txtNome.Location = new System.Drawing.Point(160, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Preenchimento = null;
            this.txtNome.Size = new System.Drawing.Size(356, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "NOME";
            this.txtNome.TipoCampo = null;
            // 
            // labelJCS2
            // 
            this.labelJCS2.AutoSize = true;
            this.labelJCS2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS2.Location = new System.Drawing.Point(548, 109);
            this.labelJCS2.Name = "labelJCS2";
            this.labelJCS2.Size = new System.Drawing.Size(104, 17);
            this.labelJCS2.TabIndex = 19;
            this.labelJCS2.Text = "DT. Nascimento:";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpNascimento.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNascimento.Location = new System.Drawing.Point(658, 102);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(130, 24);
            this.dtpNascimento.TabIndex = 10;
            this.dtpNascimento.Value = new System.DateTime(2024, 5, 29, 0, 0, 0, 0);
            // 
            // dtpSaida
            // 
            this.dtpSaida.CustomFormat = "dd/MM/yyyy";
            this.dtpSaida.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaida.Location = new System.Drawing.Point(324, 136);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(130, 24);
            this.dtpSaida.TabIndex = 12;
            this.dtpSaida.Value = new System.DateTime(2024, 5, 29, 0, 0, 0, 0);
            // 
            // labelJCS3
            // 
            this.labelJCS3.AutoSize = true;
            this.labelJCS3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS3.Location = new System.Drawing.Point(274, 143);
            this.labelJCS3.Name = "labelJCS3";
            this.labelJCS3.Size = new System.Drawing.Size(44, 17);
            this.labelJCS3.TabIndex = 21;
            this.labelJCS3.Text = "Saída:";
            // 
            // labelJCS4
            // 
            this.labelJCS4.AutoSize = true;
            this.labelJCS4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS4.Location = new System.Drawing.Point(602, 143);
            this.labelJCS4.Name = "labelJCS4";
            this.labelJCS4.Size = new System.Drawing.Size(50, 17);
            this.labelJCS4.TabIndex = 23;
            this.labelJCS4.Text = "Status:";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "SELECIONE",
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(658, 140);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(130, 23);
            this.cboStatus.TabIndex = 24;
            // 
            // labelJCS5
            // 
            this.labelJCS5.AutoSize = true;
            this.labelJCS5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS5.Location = new System.Drawing.Point(30, 75);
            this.labelJCS5.Name = "labelJCS5";
            this.labelJCS5.Size = new System.Drawing.Size(68, 17);
            this.labelJCS5.TabIndex = 25;
            this.labelJCS5.Text = "Endereço:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.BackColor = System.Drawing.Color.White;
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtLogradouro.IconeKeyDown = null;
            this.txtLogradouro.Location = new System.Drawing.Point(104, 72);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Preenchimento = null;
            this.txtLogradouro.Size = new System.Drawing.Size(214, 24);
            this.txtLogradouro.TabIndex = 3;
            this.txtLogradouro.Text = "RUA/AVENIDA/LOGRADOURO";
            this.txtLogradouro.TipoCampo = null;
            // 
            // ttxNumero
            // 
            this.ttxNumero.BackColor = System.Drawing.Color.White;
            this.ttxNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ttxNumero.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ttxNumero.IconeKeyDown = null;
            this.ttxNumero.Location = new System.Drawing.Point(324, 72);
            this.ttxNumero.Name = "ttxNumero";
            this.ttxNumero.Preenchimento = null;
            this.ttxNumero.Size = new System.Drawing.Size(89, 24);
            this.ttxNumero.TabIndex = 4;
            this.ttxNumero.Text = "NUMERO/APT";
            this.ttxNumero.TipoCampo = null;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtBairro.IconeKeyDown = null;
            this.txtBairro.Location = new System.Drawing.Point(419, 72);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Preenchimento = null;
            this.txtBairro.Size = new System.Drawing.Size(97, 24);
            this.txtBairro.TabIndex = 5;
            this.txtBairro.Text = "BAIRRO";
            this.txtBairro.TipoCampo = null;
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCidade.IconeKeyDown = null;
            this.txtCidade.Location = new System.Drawing.Point(522, 72);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Preenchimento = null;
            this.txtCidade.Size = new System.Drawing.Size(130, 24);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.Text = "CIDADE";
            this.txtCidade.TipoCampo = null;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEstado.IconeKeyDown = null;
            this.txtEstado.Location = new System.Drawing.Point(658, 72);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Preenchimento = null;
            this.txtEstado.Size = new System.Drawing.Size(130, 24);
            this.txtEstado.TabIndex = 7;
            this.txtEstado.Text = "ESTADO";
            this.txtEstado.TipoCampo = null;
            // 
            // labelJCS6
            // 
            this.labelJCS6.AutoSize = true;
            this.labelJCS6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS6.Location = new System.Drawing.Point(38, 109);
            this.labelJCS6.Name = "labelJCS6";
            this.labelJCS6.Size = new System.Drawing.Size(60, 17);
            this.labelJCS6.TabIndex = 32;
            this.labelJCS6.Text = "Contato:";
            // 
            // txtContato
            // 
            this.txtContato.BackColor = System.Drawing.Color.White;
            this.txtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContato.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtContato.IconeKeyDown = null;
            this.txtContato.Location = new System.Drawing.Point(104, 106);
            this.txtContato.Name = "txtContato";
            this.txtContato.Preenchimento = null;
            this.txtContato.Size = new System.Drawing.Size(214, 24);
            this.txtContato.TabIndex = 8;
            this.txtContato.Text = "NUMERO TELEFONICO";
            this.txtContato.TipoCampo = null;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmail.IconeKeyDown = null;
            this.txtEmail.Location = new System.Drawing.Point(324, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Preenchimento = null;
            this.txtEmail.Size = new System.Drawing.Size(192, 24);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Text = "EMAIL";
            this.txtEmail.TipoCampo = null;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpInicio.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(104, 136);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(130, 24);
            this.dtpInicio.TabIndex = 11;
            this.dtpInicio.Value = new System.DateTime(2024, 5, 29, 0, 0, 0, 0);
            // 
            // labelJCS7
            // 
            this.labelJCS7.AutoSize = true;
            this.labelJCS7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS7.Location = new System.Drawing.Point(54, 143);
            this.labelJCS7.Name = "labelJCS7";
            this.labelJCS7.Size = new System.Drawing.Size(44, 17);
            this.labelJCS7.TabIndex = 35;
            this.labelJCS7.Text = "Inicio:";
            // 
            // labelJCS8
            // 
            this.labelJCS8.AutoSize = true;
            this.labelJCS8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS8.Location = new System.Drawing.Point(46, 169);
            this.labelJCS8.Name = "labelJCS8";
            this.labelJCS8.Size = new System.Drawing.Size(52, 17);
            this.labelJCS8.TabIndex = 37;
            this.labelJCS8.Text = "Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.White;
            this.txtSalario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtSalario.IconeKeyDown = null;
            this.txtSalario.Location = new System.Drawing.Point(104, 166);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Preenchimento = null;
            this.txtSalario.Size = new System.Drawing.Size(130, 24);
            this.txtSalario.TabIndex = 16;
            this.txtSalario.Text = "VALOR SALÁRIO";
            this.txtSalario.TipoCampo = "";
            // 
            // txtBeneficios
            // 
            this.txtBeneficios.BackColor = System.Drawing.Color.White;
            this.txtBeneficios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBeneficios.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtBeneficios.IconeKeyDown = null;
            this.txtBeneficios.Location = new System.Drawing.Point(324, 169);
            this.txtBeneficios.Name = "txtBeneficios";
            this.txtBeneficios.Preenchimento = null;
            this.txtBeneficios.Size = new System.Drawing.Size(464, 24);
            this.txtBeneficios.TabIndex = 17;
            this.txtBeneficios.Text = "DESCREVER BENIFICIOS. EX: NAO TEM DESCONTO INSS";
            this.txtBeneficios.TipoCampo = "";
            // 
            // labelJCS9
            // 
            this.labelJCS9.AutoSize = true;
            this.labelJCS9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS9.Location = new System.Drawing.Point(245, 172);
            this.labelJCS9.Name = "labelJCS9";
            this.labelJCS9.Size = new System.Drawing.Size(73, 17);
            this.labelJCS9.TabIndex = 39;
            this.labelJCS9.Text = "Benefícios:";
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 27;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 68;
            // 
            // colRua
            // 
            this.colRua.HeaderText = "Logradouro";
            this.colRua.Name = "colRua";
            this.colRua.ReadOnly = true;
            this.colRua.Width = 103;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Nº";
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 48;
            // 
            // colBairro
            // 
            this.colBairro.HeaderText = "Bairro";
            this.colBairro.Name = "colBairro";
            this.colBairro.ReadOnly = true;
            this.colBairro.Width = 69;
            // 
            // colCidade
            // 
            this.colCidade.HeaderText = "Cidade";
            this.colCidade.Name = "colCidade";
            this.colCidade.ReadOnly = true;
            this.colCidade.Width = 73;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "ESTADO";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 74;
            // 
            // colContato
            // 
            this.colContato.HeaderText = "Telefone";
            this.colContato.Name = "colContato";
            this.colContato.ReadOnly = true;
            this.colContato.Width = 83;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 64;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.HeaderText = "Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            this.colDataNascimento.Width = 103;
            // 
            // colDtInicio
            // 
            this.colDtInicio.HeaderText = "Inicio";
            this.colDtInicio.Name = "colDtInicio";
            this.colDtInicio.ReadOnly = true;
            this.colDtInicio.Width = 65;
            // 
            // colDtSaida
            // 
            this.colDtSaida.HeaderText = "Saída";
            this.colDtSaida.Name = "colDtSaida";
            this.colDtSaida.ReadOnly = true;
            this.colDtSaida.Width = 65;
            // 
            // colSalario
            // 
            this.colSalario.HeaderText = "Salário";
            this.colSalario.Name = "colSalario";
            this.colSalario.ReadOnly = true;
            this.colSalario.Width = 73;
            // 
            // colBeneficios
            // 
            this.colBeneficios.HeaderText = "Benefícios";
            this.colBeneficios.Name = "colBeneficios";
            this.colBeneficios.ReadOnly = true;
            this.colBeneficios.Width = 94;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 52;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.txtCPF.IconeKeyDown = null;
            this.txtCPF.Location = new System.Drawing.Point(658, 42);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Preenchimento = null;
            this.txtCPF.Size = new System.Drawing.Size(130, 24);
            this.txtCPF.TabIndex = 2;
            this.txtCPF.Text = "CPF";
            this.txtCPF.TipoCampo = null;
            // 
            // labelJCS10
            // 
            this.labelJCS10.AutoSize = true;
            this.labelJCS10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.labelJCS10.Location = new System.Drawing.Point(620, 45);
            this.labelJCS10.Name = "labelJCS10";
            this.labelJCS10.Size = new System.Drawing.Size(32, 17);
            this.labelJCS10.TabIndex = 42;
            this.labelJCS10.Text = "CPF:";
            // 
            // frmCadastroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelJCS10);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtBeneficios);
            this.Controls.Add(this.labelJCS9);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelJCS8);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.labelJCS7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.labelJCS6);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.ttxNumero);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.labelJCS5);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.labelJCS4);
            this.Controls.Add(this.dtpSaida);
            this.Controls.Add(this.labelJCS3);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.labelJCS2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labelJCS1);
            this.Controls.Add(this.dgvColaboradores);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmCadastroColaborador";
            this.Text = "frmCadastroColaborador";
            this.Controls.SetChildIndex(this.dgvColaboradores, 0);
            this.Controls.SetChildIndex(this.labelJCS1, 0);
            this.Controls.SetChildIndex(this.txtID, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.labelJCS2, 0);
            this.Controls.SetChildIndex(this.dtpNascimento, 0);
            this.Controls.SetChildIndex(this.labelJCS3, 0);
            this.Controls.SetChildIndex(this.dtpSaida, 0);
            this.Controls.SetChildIndex(this.labelJCS4, 0);
            this.Controls.SetChildIndex(this.cboStatus, 0);
            this.Controls.SetChildIndex(this.labelJCS5, 0);
            this.Controls.SetChildIndex(this.txtLogradouro, 0);
            this.Controls.SetChildIndex(this.ttxNumero, 0);
            this.Controls.SetChildIndex(this.txtBairro, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.labelJCS6, 0);
            this.Controls.SetChildIndex(this.txtContato, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.labelJCS7, 0);
            this.Controls.SetChildIndex(this.dtpInicio, 0);
            this.Controls.SetChildIndex(this.labelJCS8, 0);
            this.Controls.SetChildIndex(this.txtSalario, 0);
            this.Controls.SetChildIndex(this.labelJCS9, 0);
            this.Controls.SetChildIndex(this.txtBeneficios, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.labelJCS10, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.DataGridViewJCS dgvColaboradores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeneficios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
        private Componentes.LabelJCS labelJCS1;
        private Componentes.TextBoxJCS txtID;
        private Componentes.TextBoxJCS txtNome;
        private Componentes.LabelJCS labelJCS2;
        private Componentes.dateTimePickerJCS dtpNascimento;
        private Componentes.dateTimePickerJCS dtpSaida;
        private Componentes.LabelJCS labelJCS3;
        private Componentes.LabelJCS labelJCS4;
        private Componentes.ComboBoxJCS cboStatus;
        private Componentes.LabelJCS labelJCS5;
        private Componentes.TextBoxJCS txtLogradouro;
        private Componentes.TextBoxJCS ttxNumero;
        private Componentes.TextBoxJCS txtBairro;
        private Componentes.TextBoxJCS txtCidade;
        private Componentes.TextBoxJCS txtEstado;
        private Componentes.LabelJCS labelJCS6;
        private Componentes.TextBoxJCS txtContato;
        private Componentes.TextBoxJCS txtEmail;
        private Componentes.dateTimePickerJCS dtpInicio;
        private Componentes.LabelJCS labelJCS7;
        private Componentes.LabelJCS labelJCS8;
        private Componentes.TextBoxJCS txtSalario;
        private Componentes.TextBoxJCS txtBeneficios;
        private Componentes.LabelJCS labelJCS9;
        private Componentes.TextBoxJCS txtCPF;
        private Componentes.LabelJCS labelJCS10;
    }
}