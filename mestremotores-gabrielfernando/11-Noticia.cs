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
    public partial class frmNoticia : Form
    {
        public frmNoticia()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarNoticia()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_noticia WHERE status_noticia <> 'DESATIVADO' ORDER BY nome_noticia;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNoticia.DataSource = dt;
                dgvNoticia.Columns[0].Visible = false;
                dgvNoticia.Columns[1].HeaderText = "NOME";
                dgvNoticia.Columns[2].HeaderText = "DESCRIÇÃO";
                dgvNoticia.Columns[3].Visible = false;
                dgvNoticia.Columns[4].Visible = false;
                dgvNoticia.Columns[5].Visible = false;                            
                dgvNoticia.Columns[6].HeaderText = "STATUS";
                dgvNoticia.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar as noticias. " + erro);
                throw;
            }
        }

        private void frmNoticia_Load(object sender, EventArgs e)
        {
            CarregarNoticia();
        }
    }
}
