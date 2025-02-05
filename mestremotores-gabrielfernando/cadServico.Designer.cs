namespace mestremotores_gabrielfernando
{
    partial class frmCadServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadServico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFoto = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.mskDuração = new System.Windows.Forms.MaskedTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbEspecialidade = new System.Windows.Forms.ComboBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEspecialidade = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel2.Controls.Add(this.btnFechar);
            this.panel2.Controls.Add(this.lblFuncao);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblFuncao
            // 
            resources.ApplyResources(this.lblFuncao, "lblFuncao");
            this.lblFuncao.ForeColor = System.Drawing.Color.White;
            this.lblFuncao.Name = "lblFuncao";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.mskDuração);
            this.panel3.Controls.Add(this.cmbStatus);
            this.panel3.Controls.Add(this.cmbEspecialidade);
            this.panel3.Controls.Add(this.txtTipo);
            this.panel3.Controls.Add(this.txtValor);
            this.panel3.Controls.Add(this.txtDescricao);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.lblDuracao);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.lblEspecialidade);
            this.panel3.Controls.Add(this.lblTipo);
            this.panel3.Controls.Add(this.lblValor);
            this.panel3.Controls.Add(this.lblDescricao);
            this.panel3.Controls.Add(this.lblNome);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.btnFoto);
            this.panel4.Controls.Add(this.lblFoto);
            this.panel4.Controls.Add(this.pctFoto);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.btnFoto, "btnFoto");
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnFoto_KeyPress);
            // 
            // lblFoto
            // 
            resources.ApplyResources(this.lblFoto, "lblFoto");
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.ForeColor = System.Drawing.Color.White;
            this.lblFoto.Name = "lblFoto";
            // 
            // pctFoto
            // 
            this.pctFoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.pctFoto, "pctFoto");
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.TabStop = false;
            // 
            // mskDuração
            // 
            resources.ApplyResources(this.mskDuração, "mskDuração");
            this.mskDuração.Name = "mskDuração";
            this.mskDuração.ValidatingType = typeof(System.DateTime);
            this.mskDuração.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskDuração_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            resources.GetString("cmbStatus.Items"),
            resources.GetString("cmbStatus.Items1"),
            resources.GetString("cmbStatus.Items2"),
            resources.GetString("cmbStatus.Items3")});
            resources.ApplyResources(this.cmbStatus, "cmbStatus");
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // cmbEspecialidade
            // 
            this.cmbEspecialidade.FormattingEnabled = true;
            resources.ApplyResources(this.cmbEspecialidade, "cmbEspecialidade");
            this.cmbEspecialidade.Name = "cmbEspecialidade";
            this.cmbEspecialidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEspecialidade_KeyPress);
            // 
            // txtTipo
            // 
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtTipo, "txtTipo");
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTipo_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.Name = "txtValor";
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtDescricao, "txtDescricao");
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblDuracao
            // 
            resources.ApplyResources(this.lblDuracao, "lblDuracao");
            this.lblDuracao.ForeColor = System.Drawing.Color.White;
            this.lblDuracao.Name = "lblDuracao";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            // 
            // lblEspecialidade
            // 
            resources.ApplyResources(this.lblEspecialidade, "lblEspecialidade");
            this.lblEspecialidade.ForeColor = System.Drawing.Color.White;
            this.lblEspecialidade.Name = "lblEspecialidade";
            // 
            // lblTipo
            // 
            resources.ApplyResources(this.lblTipo, "lblTipo");
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Name = "lblTipo";
            // 
            // lblValor
            // 
            resources.ApplyResources(this.lblValor, "lblValor");
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Name = "lblValor";
            // 
            // lblDescricao
            // 
            resources.ApplyResources(this.lblDescricao, "lblDescricao");
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Name = "lblDescricao";
            // 
            // lblNome
            // 
            resources.ApplyResources(this.lblNome, "lblNome");
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Name = "lblNome";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.btnLimpar, "btnLimpar");
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            resources.ApplyResources(this.btnSalvar, "btnSalvar");
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // frmCadServico
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadServico";
            this.Load += new System.EventHandler(this.frmCadServico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEspecialidade;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.MaskedTextBox mskDuração;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbEspecialidade;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox pctFoto;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnFoto;
    }
}