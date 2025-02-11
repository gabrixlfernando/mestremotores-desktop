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
    public partial class frmMenuPrincipal : Form
    {

        int codContato;
        string emailContato;
        string mensagemContato;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var sair = MessageBox.Show("Deseja encerrar o sistema?", "ENCERRAR", MessageBoxButtons.YesNoCancel);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (sair == DialogResult.No)
            {
                new frmLogin().Show();  
                Close();
            }
        }

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timerDataHora.Start();
            timerEmail.Start();
            CarregarEmail();
        }

        private void CarregarEmail()
        {
            try
            {
                Banco.Conectar();

                string selecionar = "SELECT * FROM tbl_contato WHERE status_contato <> 'Excluído' ORDER BY id_contato DESC;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvContato.DataSource = dt;
                dgvContato.Columns[0].Visible = false;
                dgvContato.Columns[1].HeaderText = "NOME";
                dgvContato.Columns[2].HeaderText = "TELEFONE";
                dgvContato.Columns[3].HeaderText = "E-MAIL";
                dgvContato.Columns[4].Visible = false;
                dgvContato.Columns[5].HeaderText = "STATUS";
                dgvContato.Columns[6].Visible = false;

                Banco.Desconectar();

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao carregar os emails. \n" + erro);

            }
        }

        private void dgvContato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 5 && e.Value != null){
                    
                    if(e.Value.ToString().Equals("Aguardando", StringComparison.OrdinalIgnoreCase))
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao formatar a cor da célula. \n" + erro);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvContato.Rows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);

                MessageBox.Show(codContato.ToString());

            }
            ExcluirContato();
            CarregarEmail();
        }

        private void ExcluirContato()
        {
            try
            {
                Banco.Conectar();

                string excluir = "UPDATE tbl_contato SET status_contato = 'Excluído' WHERE id_contato = @codContato;";
                MySqlCommand cmd = new MySqlCommand(excluir, Banco.conexao);
                cmd.Parameters.AddWithValue("@codContato", codContato);
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao excluir o Email. \n" + erro);
            }
        }

        

        private void timerEmail_Tick(object sender, EventArgs e)
        {
            CarregarEmail();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (dgvContato.Rows.Count > 0)
            {
                codContato = Convert.ToInt32(dgvContato.SelectedRows[0].Cells[0].Value);
                emailContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[3].Value.ToString());
                mensagemContato = Convert.ToString(dgvContato.SelectedRows[0].Cells[4].Value.ToString());

                new frmResponderEmail(emailContato, mensagemContato, codContato).ShowDialog();

                CarregarEmail();

            }
        }

        private void pctCliente_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Hide();
        }

        private void pctFuncionario_Click(object sender, EventArgs e)
        {
            new frmFuncionario().Show();
            Hide();
        }

        private void pctEspecialidade_Click(object sender, EventArgs e)
        {
            new frmEspecialidade().Show();
            Hide();
        }

        private void pctBanner_Click(object sender, EventArgs e)
        {
            new frmBanner().Show();
            Hide();
        }

        private void pctServico_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Hide();
        }

        private void pctMarca_Click(object sender, EventArgs e)
        {
            new frmMarca().Show();
            Hide();
        }

        private void pctVeiculo_Click(object sender, EventArgs e)
        {
            new frmVeiculo().Show();
            Hide();
        }

        private void pctNoticia_Click(object sender, EventArgs e)
        {
            new frmNoticia().Show();
            Hide();
        }

        private void pctVideo_Click(object sender, EventArgs e)
        {
            new frmVideo().Show();
            Hide();
        }

        private void pctGaleria_Click(object sender, EventArgs e)
        {
            new frmGaleria().Show();
            Hide();
        }

      
    }
}
