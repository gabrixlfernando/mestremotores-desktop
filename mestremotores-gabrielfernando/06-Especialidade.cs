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
    public partial class frmEspecialidade : Form
    {
        public frmEspecialidade()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarEspecialidade()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_especialidade WHERE status_especialidade <> 'DESATIVADO' ORDER BY nome_especialidade;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEspecialidade.DataSource = dt;
                dgvEspecialidade.Columns[0].Visible = false;
                dgvEspecialidade.Columns[1].HeaderText = "NOME";
                dgvEspecialidade.Columns[2].HeaderText = "STATUS";
                dgvEspecialidade.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar as especialidades. " + erro);
                throw;
            }
        }

        private void frmEspecialidade_Load(object sender, EventArgs e)
        {
            CarregarEspecialidade();
        }
    }
}
