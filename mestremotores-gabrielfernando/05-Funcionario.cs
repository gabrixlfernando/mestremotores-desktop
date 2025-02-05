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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarFuncionario()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_funcionario WHERE status_funcionario <> 'DESATIVADO' ORDER BY nome_funcionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME";
                dgvFuncionario.Columns[2].Visible = false;
                dgvFuncionario.Columns[3].HeaderText = "ENDEREÇO";
                dgvFuncionario.Columns[4].HeaderText = "BAIRRO";
                dgvFuncionario.Columns[5].HeaderText = "CIDADE";
                dgvFuncionario.Columns[6].HeaderText = "UF";
                dgvFuncionario.Columns[7].HeaderText = "TELEFONE";
                dgvFuncionario.Columns[8].HeaderText = "E-MAIL";
                dgvFuncionario.Columns[9].Visible = false;
                dgvFuncionario.Columns[10].Visible = false;
                dgvFuncionario.Columns[11].HeaderText = "STATUS";
                dgvFuncionario.Columns[12].Visible = false;
                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os funcionarios. " + erro);
                throw;
            }
        }
        private void CarregarFuncionarioNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_funcionario WHERE nome_funcionario LIKE @nome ORDER BY nome_funcionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + txtFuncionario.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME";
                dgvFuncionario.Columns[2].Visible = false;
                dgvFuncionario.Columns[3].HeaderText = "ENDEREÇO";
                dgvFuncionario.Columns[4].HeaderText = "BAIRRO";
                dgvFuncionario.Columns[5].HeaderText = "CIDADE";
                dgvFuncionario.Columns[6].HeaderText = "UF";
                dgvFuncionario.Columns[7].HeaderText = "TELEFONE";
                dgvFuncionario.Columns[8].HeaderText = "E-MAIL";
                dgvFuncionario.Columns[9].Visible = false;
                dgvFuncionario.Columns[10].Visible = false;
                dgvFuncionario.Columns[11].HeaderText = "STATUS";
                dgvFuncionario.Columns[12].Visible = false;
                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os funcionarios. " + erro);
                throw;
            }
        }private void CarregarFuncionarioStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_funcionario WHERE status_funcionario = @status ORDER BY nome_funcionario;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFuncionario.DataSource = dt;
                dgvFuncionario.Columns[0].Visible = false;
                dgvFuncionario.Columns[1].HeaderText = "NOME";
                dgvFuncionario.Columns[2].Visible = false;
                dgvFuncionario.Columns[3].HeaderText = "ENDEREÇO";
                dgvFuncionario.Columns[4].HeaderText = "BAIRRO";
                dgvFuncionario.Columns[5].HeaderText = "CIDADE";
                dgvFuncionario.Columns[6].HeaderText = "UF";
                dgvFuncionario.Columns[7].HeaderText = "TELEFONE";
                dgvFuncionario.Columns[8].HeaderText = "E-MAIL";
                dgvFuncionario.Columns[9].Visible = false;
                dgvFuncionario.Columns[10].Visible = false;
                dgvFuncionario.Columns[11].HeaderText = "STATUS";
                dgvFuncionario.Columns[12].Visible = false;
                dgvFuncionario.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os funcionarios. " + erro);
                throw;
            }
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            CarregarFuncionario();
        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            if (txtFuncionario.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarFuncionarioNome();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarFuncionario();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtFuncionario.Enabled = false;
                CarregarFuncionarioStatus();
            }
            else
            {
                txtFuncionario.Enabled = true;
                CarregarFuncionario();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadFuncionario().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadFuncionario().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha da tabela.");
            }
            MessageBox.Show(Variaveis.linhaSelecionada.ToString());
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
        }
    }
}
