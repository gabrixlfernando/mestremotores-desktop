namespace mestremotores_gabrielfernando
{
    partial class frmMenuPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dgvContato = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNomeUsuário = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.timerEmail = new System.Windows.Forms.Timer(this.components);
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctGaleria = new System.Windows.Forms.PictureBox();
            this.pctVideo = new System.Windows.Forms.PictureBox();
            this.pctNoticia = new System.Windows.Forms.PictureBox();
            this.pctBanner = new System.Windows.Forms.PictureBox();
            this.pctServico = new System.Windows.Forms.PictureBox();
            this.pctEspecialidade = new System.Windows.Forms.PictureBox();
            this.pctFuncionario = new System.Windows.Forms.PictureBox();
            this.pctCliente = new System.Windows.Forms.PictureBox();
            this.pctVeiculo = new System.Windows.Forms.PictureBox();
            this.pctMarca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoticia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEspecialidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.ForeColor = System.Drawing.Color.White;
            this.btnVisualizar.Location = new System.Drawing.Point(783, 282);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(150, 45);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(783, 333);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(150, 45);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dgvContato
            // 
            this.dgvContato.AllowUserToAddRows = false;
            this.dgvContato.AllowUserToDeleteRows = false;
            this.dgvContato.AllowUserToResizeColumns = false;
            this.dgvContato.AllowUserToResizeRows = false;
            this.dgvContato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContato.EnableHeadersVisualStyles = false;
            this.dgvContato.Location = new System.Drawing.Point(268, 45);
            this.dgvContato.MultiSelect = false;
            this.dgvContato.Name = "dgvContato";
            this.dgvContato.ReadOnly = true;
            this.dgvContato.RowHeadersVisible = false;
            this.dgvContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContato.Size = new System.Drawing.Size(650, 217);
            this.dgvContato.TabIndex = 3;
            this.dgvContato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContato_CellFormatting);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(883, 4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lblUsuario.Location = new System.Drawing.Point(268, 15);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(87, 24);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblNomeUsuário
            // 
            this.lblNomeUsuário.AutoSize = true;
            this.lblNomeUsuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuário.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lblNomeUsuário.Location = new System.Drawing.Point(361, 15);
            this.lblNomeUsuário.Name = "lblNomeUsuário";
            this.lblNomeUsuário.Size = new System.Drawing.Size(143, 24);
            this.lblNomeUsuário.TabIndex = 5;
            this.lblNomeUsuário.Text = "Nome Usuário";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(808, 473);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(110, 24);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "00/00/0000";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
       
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(817, 521);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(88, 24);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "00:00:00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDataHora
            // 
            this.timerDataHora.Interval = 1000;
            this.timerDataHora.Tick += new System.EventHandler(this.timerDataHora_Tick);
            // 
            // timerEmail
            // 
            this.timerEmail.Interval = 10000;
            this.timerEmail.Tick += new System.EventHandler(this.timerEmail_Tick);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::mestremotores_gabrielfernando.Properties.Resources.iconeTexto;
            this.pctLogo.Location = new System.Drawing.Point(12, 12);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(250, 250);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 2;
            this.pctLogo.TabStop = false;
            // 
            // pctGaleria
            // 
            this.pctGaleria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctGaleria.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnGaleria;
            this.pctGaleria.Location = new System.Drawing.Point(630, 438);
            this.pctGaleria.Name = "pctGaleria";
            this.pctGaleria.Size = new System.Drawing.Size(150, 150);
            this.pctGaleria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctGaleria.TabIndex = 0;
            this.pctGaleria.TabStop = false;
            this.pctGaleria.Click += new System.EventHandler(this.pctGaleria_Click);
            // 
            // pctVideo
            // 
            this.pctVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctVideo.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnVideo;
            this.pctVideo.Location = new System.Drawing.Point(474, 438);
            this.pctVideo.Name = "pctVideo";
            this.pctVideo.Size = new System.Drawing.Size(150, 150);
            this.pctVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVideo.TabIndex = 0;
            this.pctVideo.TabStop = false;
            this.pctVideo.Click += new System.EventHandler(this.pctVideo_Click);
            // 
            // pctNoticia
            // 
            this.pctNoticia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctNoticia.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnNoticia;
            this.pctNoticia.Location = new System.Drawing.Point(318, 438);
            this.pctNoticia.Name = "pctNoticia";
            this.pctNoticia.Size = new System.Drawing.Size(150, 150);
            this.pctNoticia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctNoticia.TabIndex = 0;
            this.pctNoticia.TabStop = false;
            this.pctNoticia.Click += new System.EventHandler(this.pctNoticia_Click);
            // 
            // pctBanner
            // 
            this.pctBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctBanner.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnBanner;
            this.pctBanner.Location = new System.Drawing.Point(630, 282);
            this.pctBanner.Name = "pctBanner";
            this.pctBanner.Size = new System.Drawing.Size(150, 150);
            this.pctBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBanner.TabIndex = 0;
            this.pctBanner.TabStop = false;
            this.pctBanner.Click += new System.EventHandler(this.pctBanner_Click);
            // 
            // pctServico
            // 
            this.pctServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctServico.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnServico;
            this.pctServico.Location = new System.Drawing.Point(474, 282);
            this.pctServico.Name = "pctServico";
            this.pctServico.Size = new System.Drawing.Size(150, 150);
            this.pctServico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctServico.TabIndex = 0;
            this.pctServico.TabStop = false;
            this.pctServico.Click += new System.EventHandler(this.pctServico_Click);
            // 
            // pctEspecialidade
            // 
            this.pctEspecialidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctEspecialidade.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnEspecialidade;
            this.pctEspecialidade.Location = new System.Drawing.Point(318, 282);
            this.pctEspecialidade.Name = "pctEspecialidade";
            this.pctEspecialidade.Size = new System.Drawing.Size(150, 150);
            this.pctEspecialidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEspecialidade.TabIndex = 0;
            this.pctEspecialidade.TabStop = false;
            this.pctEspecialidade.Click += new System.EventHandler(this.pctEspecialidade_Click);
            // 
            // pctFuncionario
            // 
            this.pctFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctFuncionario.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnFuncionario;
            this.pctFuncionario.Location = new System.Drawing.Point(162, 282);
            this.pctFuncionario.Name = "pctFuncionario";
            this.pctFuncionario.Size = new System.Drawing.Size(150, 150);
            this.pctFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFuncionario.TabIndex = 0;
            this.pctFuncionario.TabStop = false;
            this.pctFuncionario.Click += new System.EventHandler(this.pctFuncionario_Click);
            // 
            // pctCliente
            // 
            this.pctCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctCliente.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnCliente;
            this.pctCliente.Location = new System.Drawing.Point(6, 282);
            this.pctCliente.Name = "pctCliente";
            this.pctCliente.Size = new System.Drawing.Size(150, 150);
            this.pctCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCliente.TabIndex = 0;
            this.pctCliente.TabStop = false;
            this.pctCliente.Click += new System.EventHandler(this.pctCliente_Click);
            // 
            // pctVeiculo
            // 
            this.pctVeiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.pctVeiculo.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnVeiculo;
            this.pctVeiculo.Location = new System.Drawing.Point(162, 438);
            this.pctVeiculo.Name = "pctVeiculo";
            this.pctVeiculo.Size = new System.Drawing.Size(150, 150);
            this.pctVeiculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVeiculo.TabIndex = 0;
            this.pctVeiculo.TabStop = false;
            this.pctVeiculo.Click += new System.EventHandler(this.pctVeiculo_Click);
            // 
            // pctMarca
            // 
            this.pctMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.pctMarca.Image = global::mestremotores_gabrielfernando.Properties.Resources.btnMarca;
            this.pctMarca.Location = new System.Drawing.Point(6, 438);
            this.pctMarca.Name = "pctMarca";
            this.pctMarca.Size = new System.Drawing.Size(150, 150);
            this.pctMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMarca.TabIndex = 0;
            this.pctMarca.TabStop = false;
            this.pctMarca.Click += new System.EventHandler(this.pctMarca_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 600);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeUsuário);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dgvContato);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.pctGaleria);
            this.Controls.Add(this.pctVideo);
            this.Controls.Add(this.pctNoticia);
            this.Controls.Add(this.pctBanner);
            this.Controls.Add(this.pctServico);
            this.Controls.Add(this.pctEspecialidade);
            this.Controls.Add(this.pctFuncionario);
            this.Controls.Add(this.pctCliente);
            this.Controls.Add(this.pctVeiculo);
            this.Controls.Add(this.pctMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctNoticia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEspecialidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMarca;
        private System.Windows.Forms.PictureBox pctVeiculo;
        private System.Windows.Forms.PictureBox pctCliente;
        private System.Windows.Forms.PictureBox pctNoticia;
        private System.Windows.Forms.PictureBox pctVideo;
        private System.Windows.Forms.PictureBox pctGaleria;
        private System.Windows.Forms.PictureBox pctFuncionario;
        private System.Windows.Forms.PictureBox pctEspecialidade;
        private System.Windows.Forms.PictureBox pctServico;
        private System.Windows.Forms.PictureBox pctBanner;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.DataGridView dgvContato;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNomeUsuário;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.Timer timerEmail;
    }
}