namespace mestremotores_gabrielfernando
{
    partial class frmResponderEmail
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.rtbResposta = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnResponder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lblEmail.Location = new System.Drawing.Point(181, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 30);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lblAssunto.Location = new System.Drawing.Point(164, 110);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(90, 30);
            this.lblAssunto.TabIndex = 0;
            this.lblAssunto.Text = "Assunto";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lblMensagem.Location = new System.Drawing.Point(112, 149);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(118, 30);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Mensagem";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lblResposta.Location = new System.Drawing.Point(404, 149);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(99, 30);
            this.lblResposta.TabIndex = 0;
            this.lblResposta.Text = "Resposta";
            this.lblResposta.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(260, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(260, 120);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(273, 20);
            this.txtAssunto.TabIndex = 1;
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Location = new System.Drawing.Point(115, 185);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(521, 217);
            this.rtbMensagem.TabIndex = 2;
            this.rtbMensagem.Text = "";
            // 
            // rtbResposta
            // 
            this.rtbResposta.Location = new System.Drawing.Point(407, 185);
            this.rtbResposta.Name = "rtbResposta";
            this.rtbResposta.Size = new System.Drawing.Size(229, 217);
            this.rtbResposta.TabIndex = 2;
            this.rtbResposta.Text = "";
            this.rtbResposta.Visible = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(551, 410);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(129, 41);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Visible = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 49);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESPONDER E-MAIL";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(653, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.White;
            this.btnResponder.Location = new System.Drawing.Point(260, 410);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(129, 41);
            this.btnResponder.TabIndex = 5;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // frmResponderEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.rtbMensagem);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rtbResposta);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResponderEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.RichTextBox rtbMensagem;
        private System.Windows.Forms.RichTextBox rtbResposta;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnResponder;
    }
}