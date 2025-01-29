using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;

namespace mestremotores_gabrielfernando
{
    public partial class frmResponderEmail : Form
    {

        string emailContato, mensagemContato;
        int codContato;

        public frmResponderEmail(string email, string mensagem, int id)
        {
            InitializeComponent();
            emailContato = email;
            mensagemContato = mensagem;
            codContato = id;

            txtEmail.Text = emailContato;
            rtbMensagem.Text = mensagemContato;

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.hostinger.com", 587);
                smtpClient.Credentials = new System.Net.NetworkCredential("ti26@smpsistema.com.br", "Senac@ti26");
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("ti26@smpsistema.com.br");
                mailMessage.To.Add(emailContato);
                mailMessage.Subject = txtAssunto.Text;
                mailMessage.Body = rtbResposta.Text;
                mailMessage.IsBodyHtml = false;

                smtpClient.Send(mailMessage);

                AtualizarStatus(codContato);

                MessageBox.Show("E-mail enviado com sucesso!", "Sucesso");

                Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao enviar o Email. \n" + erro, "Erro");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            lblResposta.Visible = true;
            rtbResposta.Visible = true;
            btnEnviar.Visible = true;
            rtbMensagem.Size = new Size(229, 217);
        }

        private void AtualizarStatus(int codContato)
        {
            try
            {
                Banco.Conectar();

                string responder = "UPDATE tbl_contato SET status_contato = 'Respondido' WHERE id_contato = @codContato;";
                MySqlCommand cmd = new MySqlCommand(responder, Banco.conexao);
                cmd.Parameters.AddWithValue("@codContato", codContato);
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao responder o Email. \n" + erro);
            }
        }
    }
}
