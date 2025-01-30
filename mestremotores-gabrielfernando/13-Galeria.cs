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
    public partial class frmGaleria : Form
    {
        public frmGaleria()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarGaleria()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_galeria WHERE status_galeria <> 'DESATIVADO' ORDER BY nome_galeria;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGaleria.DataSource = dt;
                dgvGaleria.Columns[0].Visible = false;
                dgvGaleria.Columns[1].HeaderText = "NOME";
                dgvGaleria.Columns[2].HeaderText = "FOTO";
                dgvGaleria.Columns[3].HeaderText = "ALT";
                dgvGaleria.Columns[4].HeaderText = "STATUS";
                dgvGaleria.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a galeria. " + erro);
                throw;
            }
        }

        private void frmGaleria_Load(object sender, EventArgs e)
        {
            CarregarGaleria();
        }
    }
}
