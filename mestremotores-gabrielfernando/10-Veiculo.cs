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
        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            CarregarVeiculo();
        }
    }
}
