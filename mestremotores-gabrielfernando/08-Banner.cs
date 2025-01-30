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
    public partial class frmBanner : Form
    {
        public frmBanner()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarBanner()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_banner WHERE status_banner <> 'DESATIVADO' ORDER BY nome_banner;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBanner.DataSource = dt;
                dgvBanner.Columns[0].Visible = false;
                dgvBanner.Columns[1].HeaderText = "NOME";
                dgvBanner.Columns[2].HeaderText = "FOTO";
                dgvBanner.Columns[3].HeaderText = "ALT";               
                dgvBanner.Columns[4].HeaderText = "STATUS";
                dgvBanner.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os banners. " + erro);
                throw;
            }
        }

        private void frmBanner_Load(object sender, EventArgs e)
        {
            CarregarBanner();
        }
    }
}
