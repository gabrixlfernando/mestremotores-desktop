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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarMarca()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_marca ORDER BY nome_marca;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMarca.DataSource = dt;
                dgvMarca.Columns[0].Visible = false;
                dgvMarca.Columns[1].HeaderText = "NOME";
                dgvMarca.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar as marcas. " + erro);
                throw;
            }
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            CarregarMarca();
        }
    }
}
