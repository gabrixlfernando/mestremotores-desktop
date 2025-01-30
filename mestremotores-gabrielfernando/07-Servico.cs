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
using Mysqlx.Crud;

namespace mestremotores_gabrielfernando
{
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmMenuPrincipal().Show();
            Close();
        }

        private void CarregarServico()
        {
            
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT* FROM tbl_servico WHERE status_servico<> 'DESATIVADO' ORDER BY nome_servico;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvServico.DataSource = dt;
                dgvServico.Columns[0].Visible = false;
                dgvServico.Columns[1].HeaderText = "NOME";
                dgvServico.Columns[2].HeaderText = "DESCRIÇÃO";
                dgvServico.Columns[3].HeaderText = "VALOR";
                dgvServico.Columns[4].HeaderText = "TEMPO";
                dgvServico.Columns[5].Visible = false;
                dgvServico.Columns[6].Visible = false;
                dgvServico.Columns[7].HeaderText = "TIPO";
                dgvServico.Columns[8].Visible = false;
                dgvServico.Columns[9].HeaderText = "STATUS";
                dgvServico.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os serviços. " + erro);
                throw;
            }
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            CarregarServico();
        }
    }
}
