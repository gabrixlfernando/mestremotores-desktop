namespace mestremotores_gabrielfernando
{
    partial class frmCadFuncionario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.dtpDataCad = new System.Windows.Forms.DateTimePicker();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataCad = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.lblFuncao);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(-35, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 63);
            this.panel2.TabIndex = 14;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFechar.Location = new System.Drawing.Point(997, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblFuncao.ForeColor = System.Drawing.Color.White;
            this.lblFuncao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFuncao.Location = new System.Drawing.Point(470, 9);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(152, 45);
            this.lblFuncao.TabIndex = 5;
            this.lblFuncao.Text = "FUNÇÃO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 600);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 495);
            this.label1.TabIndex = 5;
            this.label1.Text = "F\r\nU\r\nN\r\nC\r\nI\r\nO\r\nN\r\nA\r\nR\r\nI\r\nO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.cmbEspecialidade);
            this.panel3.Controls.Add(this.lblEspecialidade);
            this.panel3.Controls.Add(this.dtpDataCad);
            this.panel3.Controls.Add(this.mskTelefone);
            this.panel3.Controls.Add(this.mskCPF);
            this.panel3.Controls.Add(this.cmbStatus);
            this.panel3.Controls.Add(this.txtEstado);
            this.panel3.Controls.Add(this.txtCidade);
            this.panel3.Controls.Add(this.txtBairro);
            this.panel3.Controls.Add(this.txtSenha);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.txtEndereco);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.lblCPF);
            this.panel3.Controls.Add(this.lblTelefone);
            this.panel3.Controls.Add(this.lblEstado);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.lblDataCad);
            this.panel3.Controls.Add(this.lblSenha);
            this.panel3.Controls.Add(this.lblCidade);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblBairro);
            this.panel3.Controls.Add(this.lblEndereco);
            this.panel3.Controls.Add(this.lblNome);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(107, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 461);
            this.panel3.TabIndex = 16;
            // 
            // cmbEspecialidade
            // 
            this.cmbEspecialidade.FormattingEnabled = true;
            this.cmbEspecialidade.Location = new System.Drawing.Point(558, 269);
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.Size = new System.Drawing.Size(258, 21);
            this.cmbEspecialidade.TabIndex = 11;
            this.cmbEspecialidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEspecialidade_KeyPress);
            // 
            // lblEspecialidade
            // 
            this.lblEspecialidade.AutoSize = true;
            this.lblEspecialidade.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEspecialidade.ForeColor = System.Drawing.Color.White;
            this.lblEspecialidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEspecialidade.Location = new System.Drawing.Point(553, 236);
            this.lblEspecialidade.Name = "lblEspecialidade";
            this.lblEspecialidade.Size = new System.Drawing.Size(175, 30);
            this.lblEspecialidade.TabIndex = 10;
            this.lblEspecialidade.Text = "ESPECIALIDADE:";
            // 
            // dtpDataCad
            // 
            this.dtpDataCad.Location = new System.Drawing.Point(29, 270);
            this.dtpDataCad.Name = "dtpDataCad";
            this.dtpDataCad.Size = new System.Drawing.Size(220, 20);
            this.dtpDataCad.TabIndex = 9;
            this.dtpDataCad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpDataCad_KeyPress);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(29, 191);
            this.mskTelefone.Mask = "(00) 00000-0009";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(220, 20);
            this.mskTelefone.TabIndex = 8;
            this.mskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefone_KeyPress);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(662, 47);
            this.mskCPF.Mask = "000,000,000-90";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(154, 20);
            this.mskCPF.TabIndex = 8;
            this.mskCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCPF_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVO",
            "INATIVO",
            "DESATIVADO"});
            this.cmbStatus.Location = new System.Drawing.Point(279, 269);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(258, 21);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(722, 111);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(94, 20);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstado_KeyPress);
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(535, 111);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(172, 20);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCidade_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(367, 111);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(149, 20);
            this.txtBairro.TabIndex = 6;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Location = new System.Drawing.Point(558, 190);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(258, 20);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(279, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 20);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(29, 111);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(321, 20);
            this.txtEndereco.TabIndex = 6;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(29, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(596, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCPF.Location = new System.Drawing.Point(657, 15);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(50, 30);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTelefone.Location = new System.Drawing.Point(24, 158);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(119, 30);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "TELEFONE:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEstado.Location = new System.Drawing.Point(717, 78);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(99, 30);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "ESTADO:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(274, 236);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 30);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "STATUS:";
            // 
            // lblDataCad
            // 
            this.lblDataCad.AutoSize = true;
            this.lblDataCad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDataCad.ForeColor = System.Drawing.Color.White;
            this.lblDataCad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDataCad.Location = new System.Drawing.Point(24, 236);
            this.lblDataCad.Name = "lblDataCad";
            this.lblDataCad.Size = new System.Drawing.Size(192, 30);
            this.lblDataCad.TabIndex = 5;
            this.lblDataCad.Text = "DATA CADASTRO:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSenha.Location = new System.Drawing.Point(553, 157);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(90, 30);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "SENHA:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCidade.ForeColor = System.Drawing.Color.White;
            this.lblCidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCidade.Location = new System.Drawing.Point(530, 78);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(95, 30);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "CIDADE:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmail.Location = new System.Drawing.Point(274, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(83, 30);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblBairro.ForeColor = System.Drawing.Color.White;
            this.lblBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBairro.Location = new System.Drawing.Point(362, 78);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(98, 30);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "BAIRRO:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEndereco.ForeColor = System.Drawing.Color.White;
            this.lblEndereco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEndereco.Location = new System.Drawing.Point(24, 78);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(127, 30);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "ENDEREÇO:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(24, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(83, 30);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "NOME:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(815, 550);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLimpar.Location = new System.Drawing.Point(108, 550);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 45);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Funcionario";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpDataCad;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataCad;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbEspecialidade;
        private System.Windows.Forms.Label lblEspecialidade;
    }
}