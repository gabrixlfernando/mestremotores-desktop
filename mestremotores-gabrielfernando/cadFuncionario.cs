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
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void InserirFuncionario()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO tbl_funcionario (nome_funcionario, cpf_funcionario, endereco_funcionario, bairro_funcionario, cidade_funcionario, estado_funcionario, telefone_funcionario, email_funcionario, senha_funcionario, data_cad_funcionario, status_funcionario, id_especialidade) VALUES (@nome, @cpf, @endereco, @bairro, @cidade, @estado,@telefone, @email, @senha ,@dataCad ,@status, @codEspecialidade);";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeFuncionario);
                cmd.Parameters.AddWithValue("@cpf", Variaveis.cpfFuncionario);
                cmd.Parameters.AddWithValue("@endereco", Variaveis.enderecoFuncionario);
                cmd.Parameters.AddWithValue("@bairro", Variaveis.bairroFuncionario);
                cmd.Parameters.AddWithValue("@cidade", Variaveis.cidadeFuncionario);
                cmd.Parameters.AddWithValue("@estado", Variaveis.estadoFuncionario);
                cmd.Parameters.AddWithValue("@telefone", Variaveis.telefoneFuncionario);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailFuncionario);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senhaFuncionario);
                cmd.Parameters.AddWithValue("@dataCad", Variaveis.dataCadFuncionario.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@status", Variaveis.statusFuncionario);
                cmd.Parameters.AddWithValue("@codEspecialidade", Variaveis.codEspecialidade);
             
               
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario cadastrado com sucesso!", "CADASTRO FUNCIONARIO");
                Banco.Desconectar();


                //Estrutura pra foto
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao cadastrar Funcionario!\n\n" + erro, "ERRO");

            }
        }


        private void CarregarEspecialidade()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT id_especialidade, nome_especialidade FROM tbl_especialidade ORDER BY nome_especialidade;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbEspecialidade.DataSource = dt;
                cmbEspecialidade.DisplayMember = "nome_especialidade";
                cmbEspecialidade.ValueMember = "id_especialidade";
                cmbEspecialidade.SelectedIndex = -1;


                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carrecar especialidades. " + erro);
                throw;
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Close();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskCPF.Focus();
            }
        }

        private void mskCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEndereco.Focus();
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtBairro.Focus();
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCidade.Focus();
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEstado.Focus();
            }
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskTelefone.Focus();
            }
        }

        private void mskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtpDataCad.Focus();
            }
        }

        private void dtpDataCad_KeyPress(object sender, KeyPressEventArgs e)
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
                cmbEspecialidade.Focus();
            }
        }

        private void cmbEspecialidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskCPF.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDataCad.Value = DateTime.Today;
            cmbStatus.SelectedIndex = -1;
            cmbEspecialidade.SelectedIndex = -1;


            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.White;
            lblCPF.ForeColor = Color.White;
            lblEndereco.ForeColor = Color.White;
            lblBairro.ForeColor = Color.White;
            lblCidade.ForeColor = Color.White;
            lblEstado.ForeColor = Color.White;
            lblTelefone.ForeColor = Color.White;
            lblEmail.ForeColor = Color.White;
            lblSenha.ForeColor = Color.White;
            lblDataCad.ForeColor = Color.White;
            lblStatus.ForeColor = Color.White;
            lblEspecialidade.ForeColor = Color.White;

            if (txtNome.Text.Length == 0)
            {
                lblNome.ForeColor = Color.Red;
                MessageBox.Show("Preencha Nome.");
                txtNome.Focus();
            }
            else if (mskCPF.Text.Length == 0)
            {
                lblCPF.ForeColor = Color.Red;
                MessageBox.Show("Preencha CPF.");
                mskCPF.Focus();
            }
            else if (txtEndereco.Text.Length == 0)
            {
                lblEndereco.ForeColor = Color.Red;
                MessageBox.Show("Preencha Endereço.");
                txtEndereco.Focus();
            }
            else if (txtBairro.Text.Length == 0)
            {
                lblBairro.ForeColor = Color.Red;
                MessageBox.Show("Preencha Bairro.");
                txtBairro.Focus();
            }
            else if (txtCidade.Text.Length == 0)
            {
                lblCidade.ForeColor = Color.Red;
                MessageBox.Show("Preencha Cidade.");
                txtCidade.Focus();
            }
            else if (txtEstado.Text.Length == 0)
            {
                lblEstado.ForeColor = Color.Red;
                MessageBox.Show("Preencha Estado.");
                txtEstado.Focus();
            }
            else if (mskTelefone.Text.Length == 0)
            {
                lblTelefone.ForeColor = Color.Red;
                MessageBox.Show("Preencha Telefone.");
                mskTelefone.Focus();
            }
            else if (txtEmail.Text.Length == 0)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Preencha Email.");
                txtEmail.Focus();
            }
            else if (txtSenha.Text.Length == 0)
            {
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Preencha Senha.");
                txtSenha.Focus();
            }
            else if (dtpDataCad.Text.Length == 0)
            {
                lblDataCad.ForeColor = Color.Red;
                MessageBox.Show("Preencha Data.");
                dtpDataCad.Focus();
            }
            else if (cmbStatus.Text.Length == 0)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Preencha Status.");
                cmbStatus.Focus();
            }else if (cmbEspecialidade.Text.Length == 0)
            {
                lblEspecialidade.ForeColor = Color.Red;
                MessageBox.Show("Preencha Especialidade.");
                cmbEspecialidade.Focus();
            }
            else
            {
                Variaveis.nomeFuncionario = txtNome.Text;
                Variaveis.cpfFuncionario = mskCPF.Text;
                Variaveis.enderecoFuncionario = txtEndereco.Text;
                Variaveis.bairroFuncionario = txtBairro.Text;
                Variaveis.cidadeFuncionario = txtCidade.Text;
                Variaveis.estadoFuncionario = txtEstado.Text;
                Variaveis.telefoneFuncionario = mskTelefone.Text;
                Variaveis.emailFuncionario = txtEmail.Text;
                Variaveis.senhaFuncionario = txtSenha.Text;
                Variaveis.dataCadFuncionario = DateTime.Parse(dtpDataCad.Text);
                Variaveis.statusFuncionario = cmbStatus.Text;
                Variaveis.codEspecialidade = Convert.ToInt32(cmbEspecialidade.SelectedValue);
               

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirFuncionario();
                    Variaveis.funcao = "";
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    //AlterarServico();
                }

            }

        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            lblFuncao.Text = Variaveis.funcao;
            CarregarEspecialidade();
        }
    }
}
