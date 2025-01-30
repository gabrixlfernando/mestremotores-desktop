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
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarVideo()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_video  WHERE status_video <> 'DESATIVADO' ORDER BY nome_video;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVideo.DataSource = dt;
                dgvVideo.Columns[0].Visible = false;
                dgvVideo.Columns[1].HeaderText = "NOME";
                dgvVideo.Columns[2].Visible = false;
                dgvVideo.Columns[3].Visible = false;
                dgvVideo.Columns[4].HeaderText = "URL";               
                dgvVideo.Columns[5].HeaderText = "STATUS";
                dgvVideo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os videos. " + erro);
                throw;
            }
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            CarregarVideo();
        }
    }
}
