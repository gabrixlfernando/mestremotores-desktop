namespace mestremotores_gabrielfernando
{
    partial class frmCadEspecialidade
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.panel2.Location = new System.Drawing.Point(-35, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 63);
            this.panel2.TabIndex = 15;
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
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 481);
            this.label1.TabIndex = 5;
            this.label1.Text = "E\r\nS\r\nP\r\nE\r\nC\r\nI\r\nA\r\nL\r\nI\r\nD\r\nA\r\nD\r\nE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel3.Controls.Add(this.cmbStatus);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.lblStatus);
            this.panel3.Controls.Add(this.lblNome);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(249, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 262);
            this.panel3.TabIndex = 17;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "TODOS",
            "ATIVO",
            "INATIVO",
            "DESATIVADO"});
            this.cmbStatus.Location = new System.Drawing.Point(43, 165);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(511, 21);
            this.cmbStatus.TabIndex = 7;
            this.cmbStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbStatus_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(43, 82);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(511, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStatus.Location = new System.Drawing.Point(38, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(95, 30);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "STATUS:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNome.Location = new System.Drawing.Point(38, 49);
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
            this.btnSalvar.Location = new System.Drawing.Point(676, 444);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(150, 45);
            this.btnSalvar.TabIndex = 20;
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
            this.btnLimpar.Location = new System.Drawing.Point(249, 444);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(150, 45);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCadEspecialidade
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
            this.Name = "frmCadEspecialidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Especialidade";
            this.Load += new System.EventHandler(this.frmCadEspecialidade_Load);
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
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}