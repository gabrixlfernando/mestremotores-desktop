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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarCliente()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente WHERE status_cliente <> 'DESATIVADO' ORDER BY nome_cliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;
                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[4].HeaderText = "BAIRRO";
                dgvCliente.Columns[5].HeaderText = "CIDADE";
                dgvCliente.Columns[6].HeaderText = "UF";
                dgvCliente.Columns[7].HeaderText = "TELEFONE";
                dgvCliente.Columns[8].HeaderText = "E-MAIL";
                dgvCliente.Columns[9].Visible = false;
                dgvCliente.Columns[10].Visible = false;
                dgvCliente.Columns[11].HeaderText = "STATUS";
                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro);
                throw;
            }
        }

        private void CarregarClienteNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente WHERE nome_cliente LIKE @nome ORDER BY nome_cliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%"+txtCliente.Text+"%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;
                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[4].HeaderText = "BAIRRO";
                dgvCliente.Columns[5].HeaderText = "CIDADE";
                dgvCliente.Columns[6].HeaderText = "UF";
                dgvCliente.Columns[7].HeaderText = "TELEFONE";
                dgvCliente.Columns[8].HeaderText = "E-MAIL";
                dgvCliente.Columns[9].Visible = false;
                dgvCliente.Columns[10].Visible = false;
                dgvCliente.Columns[11].HeaderText = "STATUS";
                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro);
                throw;
            }
        }

        private void CarregarClienteStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_cliente WHERE status_cliente = @status ORDER BY nome_cliente;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status",  cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCliente.DataSource = dt;
                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].HeaderText = "NOME";
                dgvCliente.Columns[2].Visible = false;
                dgvCliente.Columns[3].HeaderText = "ENDEREÇO";
                dgvCliente.Columns[4].HeaderText = "BAIRRO";
                dgvCliente.Columns[5].HeaderText = "CIDADE";
                dgvCliente.Columns[6].HeaderText = "UF";
                dgvCliente.Columns[7].HeaderText = "TELEFONE";
                dgvCliente.Columns[8].HeaderText = "E-MAIL";
                dgvCliente.Columns[9].Visible = false;
                dgvCliente.Columns[10].Visible = false;
                dgvCliente.Columns[11].HeaderText = "STATUS";
                dgvCliente.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os clientes. " + erro);
                throw;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CarregarCliente();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtCliente.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarClienteNome();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarCliente();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtCliente.Enabled = false;
                CarregarClienteStatus();
            }
            else
            {
                txtCliente.Enabled = true;
                CarregarCliente();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadCliente().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadCliente().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha da tabela.");
            }
            MessageBox.Show(Variaveis.linhaSelecionada.ToString());
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
        }
    }
}
