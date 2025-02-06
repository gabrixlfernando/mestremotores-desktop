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
    public partial class frmCadEspecialidade : Form
    {
        public frmCadEspecialidade()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmEspecialidade().Show();
            Close();
        }

        private void InserirEspecialidade()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO tbl_especialidade (nome_especialidade, status_especialidade) VALUES (@nome, @status);";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeEspecialidade);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusEspecialidade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Especialidade cadastrada com sucesso!", "CADASTRO ESPECIALIDADE");
                Banco.Desconectar();


                //Estrutura pra foto
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao cadastrar Especialidade!\n\n" + erro, "ERRO");

            }
        }


        private void AlterarEspecialidade()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE tbl_especialidade SET nome_especialidade = @nome, status_especialidade = @status WHERE id_especialidade = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeEspecialidade);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusEspecialidade);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEspecialidade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Especialidade alterada com sucesso!", "ALTERAR ESPECIALIDADE");
                Banco.Desconectar();


                //Estrutura pra foto
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao alterar Especialidade o!\n\n" + erro, "ERRO");

            }
        }

        private void CarregarDadosEspecialidade()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT id_especialidade, nome_especialidade, status_especialidade FROM tbl_especialidade WHERE id_especialidade = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEspecialidade);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.nomeEspecialidade = dr.GetString(1);
                    Variaveis.statusEspecialidade = dr.GetString(2);

                    txtNome.Text = Variaveis.nomeEspecialidade;
                    cmbStatus.Text = Variaveis.statusEspecialidade;


                }
                Banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao carregar os dados da ESPECIALIDADE." + erro, "ERRO");
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();           
            cmbStatus.SelectedIndex = -1;

            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.White;
            lblStatus.ForeColor = Color.White;

            if (txtNome.Text.Length == 0)
            {
                lblNome.ForeColor = Color.Red;
                MessageBox.Show("Preencha Nome.");
                txtNome.Focus();
            }
            else if (cmbStatus.SelectedIndex < 0)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Preencha o Status.");
                cmbStatus.Focus();
            }
            else
            {
                Variaveis.nomeEspecialidade = txtNome.Text;
                Variaveis.statusEspecialidade = cmbStatus.Text;

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirEspecialidade();
                    Variaveis.funcao = "";
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    AlterarEspecialidade();
                }
            }
        }

        private void frmCadEspecialidade_Load(object sender, EventArgs e)
        {
            lblFuncao.Text = Variaveis.funcao;
            if (Variaveis.funcao == "ALTERAR")
            {
                CarregarDadosEspecialidade();
            }
        }
    }
}
