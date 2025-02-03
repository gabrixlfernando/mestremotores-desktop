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
    public partial class frmVeiculo : Form
    {
        public frmVeiculo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarVeiculo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_veiculo WHERE status_veiculo <> 'DESATIVADO' ORDER BY modelo_veiculo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVeiculo.DataSource = dt;
                dgvVeiculo.Columns[0].Visible = false;
                dgvVeiculo.Columns[1].Visible = false;
                dgvVeiculo.Columns[2].Visible = false;
                dgvVeiculo.Columns[3].HeaderText = "MODELO";
                dgvVeiculo.Columns[4].HeaderText = "PLACA";
                dgvVeiculo.Columns[5].HeaderText = "COR";
                dgvVeiculo.Columns[6].HeaderText = "KM";
                dgvVeiculo.Columns[7].HeaderText = "COMBUSTIVÉL";
                dgvVeiculo.Columns[8].HeaderText = "STATUS";        
                dgvVeiculo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os funcionarios. " + erro);
                throw;
            }
        }  private void CarregarVeiculoNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_veiculo WHERE modelo_veiculo LIKE @nome ORDER BY modelo_veiculo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + txtVeiculo.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVeiculo.DataSource = dt;
                dgvVeiculo.Columns[0].Visible = false;
                dgvVeiculo.Columns[1].Visible = false;
                dgvVeiculo.Columns[2].Visible = false;
                dgvVeiculo.Columns[3].HeaderText = "MODELO";
                dgvVeiculo.Columns[4].HeaderText = "PLACA";
                dgvVeiculo.Columns[5].HeaderText = "COR";
                dgvVeiculo.Columns[6].HeaderText = "KM";
                dgvVeiculo.Columns[7].HeaderText = "COMBUSTIVÉL";
                dgvVeiculo.Columns[8].HeaderText = "STATUS";        
                dgvVeiculo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os funcionarios. " + erro);
                throw;
            }
        }  private void CarregarVeiculoStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_veiculo WHERE status_veiculo = @status ORDER BY modelo_veiculo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVeiculo.DataSource = dt;
                dgvVeiculo.Columns[0].Visible = false;
                dgvVeiculo.Columns[1].Visible = false;
                dgvVeiculo.Columns[2].Visible = false;
                dgvVeiculo.Columns[3].HeaderText = "MODELO";
                dgvVeiculo.Columns[4].HeaderText = "PLACA";
                dgvVeiculo.Columns[5].HeaderText = "COR";
                dgvVeiculo.Columns[6].HeaderText = "KM";
                dgvVeiculo.Columns[7].HeaderText = "COMBUSTIVÉL";
                dgvVeiculo.Columns[8].HeaderText = "STATUS";        
                dgvVeiculo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os funcionarios. " + erro);
                throw;
            }
        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            CarregarVeiculo();
        }

        private void txtVeiculo_TextChanged(object sender, EventArgs e)
        {
            if (txtVeiculo.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarVeiculoNome();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarVeiculo();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtVeiculo.Enabled = false;
                CarregarVeiculoStatus();
            }
            else
            {
                txtVeiculo.Enabled = true;
                CarregarVeiculo();
            }
        }
    }
}
