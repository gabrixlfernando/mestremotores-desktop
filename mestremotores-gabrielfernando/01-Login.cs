using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mestremotores_gabrielfernando
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //new frmMenuPrincipal().Show();
            //Hide();
            autentic();
        }

        private void autentic()
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string pwd = txtSenha.Text.Trim();

                Banco.Conectar();
                string logar = "SELECT email_funcionario, md5(senha_funcionario),status_funcionario FROM tbl_funcionario WHERE email_funcionario = @email AND senha_funcionario = @pwd";
                MySqlCommand cmd = new MySqlCommand(logar, Banco.conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                MySqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    while (Dr.Read())
                    {
                        if (Convert.ToString(Dr["status_funcionario"]) == "ATIVO")
                        {
                            new frmMenuPrincipal().Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario Inativo!");
                            txtEmail.Focus();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("DADOS INCORRETOS. TENTE NOVAMENTE!");
                    txtEmail.Focus();
                }

                Dr.Close();
                Banco.Desconectar();

            }
            catch (Exception erro)
            {

                MessageBox.Show("ERRO ao consultar usuario no sistema. " + erro);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja encerrar o sistema?", "ENCERRAR", MessageBoxButtons.YesNoCancel);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (sair == DialogResult.No)
            {
                new frmLogin().Show();
            }
        }
    }
}
