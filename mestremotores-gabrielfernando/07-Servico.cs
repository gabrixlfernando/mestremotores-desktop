using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private PictureBox pctServico = new PictureBox();
        public frmServico()
        {
            InitializeComponent();
            pctServico.SizeMode = PictureBoxSizeMode.StretchImage;
            pctServico.BorderStyle = BorderStyle.FixedSingle;
            pctServico.Visible = false;
            pctServico.BackColor = Color.FromArgb(39, 50, 90);
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
                string selecionar = "SELECT * FROM tbl_servico WHERE status_servico<> 'DESATIVADO' ORDER BY nome_servico;";
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

                //MostrarImagem();


                dgvServico.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os serviços. " + erro);
                throw;
            }
        }
        
        private void CarregarServicoNome()
        {
            
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_servico WHERE nome_servico LIKE @nome ORDER BY nome_servico;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + txtServico.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvServico.DataSource = dt;
                //dgvServico.Columns[0].Visible = false;
                //dgvServico.Columns[1].HeaderText = "NOME";
                //dgvServico.Columns[2].HeaderText = "DESCRIÇÃO";
                //dgvServico.Columns[3].HeaderText = "VALOR";
                //dgvServico.Columns[4].HeaderText = "TEMPO";
                //dgvServico.Columns[5].Visible = false;
                //dgvServico.Columns[6].Visible = false;
                //dgvServico.Columns[7].HeaderText = "TIPO";
                //dgvServico.Columns[8].Visible = false;
                //dgvServico.Columns[9].HeaderText = "STATUS";

                //MostrarImagem();


                dgvServico.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os serviços. " + erro);
                throw;
            }
        }private void CarregarServicoStatus()
        {
            
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_servico WHERE status_servico = @status ORDER BY nome_servico;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvServico.DataSource = dt;
                //dgvServico.Columns[0].Visible = false;
                //dgvServico.Columns[1].HeaderText = "NOME";
                //dgvServico.Columns[2].HeaderText = "DESCRIÇÃO";
                //dgvServico.Columns[3].HeaderText = "VALOR";
                //dgvServico.Columns[4].HeaderText = "TEMPO";
                //dgvServico.Columns[5].Visible = false;
                //dgvServico.Columns[6].Visible = false;
                //dgvServico.Columns[7].HeaderText = "TIPO";
                //dgvServico.Columns[8].Visible = false;
                //dgvServico.Columns[9].HeaderText = "STATUS";

                //MostrarImagem();


                dgvServico.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os serviços. " + erro);
                throw;
            }
        }

        private void ExcluirServico()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE tbl_servico SET status_servico = @status WHERE id_servico = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", "DESATIVADO");
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço excluído com sucesso!", "EXCLUIR SERVIÇO");
                Banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao EXCLUIR Serviço!\n\n" + erro, "ERRO");

            }
        }


        private void MostrarImagem()
        {
            string caminhoBase = @"C:\xampp\htdocs\mestre-motores\public\uploads";

            string nomeColunaImagem = "colunaImagem";
            if (dgvServico.Columns.Contains(nomeColunaImagem))
            {
                dgvServico.Columns.Remove(nomeColunaImagem);
            }

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "FOTO";
            imgColumn.Name = nomeColunaImagem;
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvServico.Columns.Insert(0, imgColumn);

            foreach(DataGridViewRow row in dgvServico.Rows)
            {
                if (row.Cells["foto_servico"].Value != DBNull.Value)
                {
                    string caminhoRelativo = row.Cells["foto_servico"].Value.ToString();
                    string caminhoCompleto = Path.Combine(caminhoBase, caminhoRelativo);

                    if(File.Exists(caminhoCompleto))
                    {
                        row.Cells[0].Value = Image.FromFile(caminhoCompleto);
                    }
                    else
                    {
                        row.Cells[0].Value = Properties.Resources.btnServico;
                    }
                }
            }
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            CarregarServico();
            MostrarImagem();
        }

        private void dgvServico_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var cell = dgvServico.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if(cell.Value != null && cell.Value is Image img)
                {
                    pctServico.Image = img;
                    pctServico.Visible = true;

                    pctServico.Location = new Point(dgvServico.Location.X+dgvServico.Width-300, dgvServico.Location.Y);
                    pctServico.Width = 300;
                    pctServico.Height = 300;
                    this.Controls.Add(pctServico);
                    pctServico.BringToFront();
                }
            }
        }

        private void dgvServico_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                pctServico.Visible =false;
            }
        }

        private void txtServico_TextChanged(object sender, EventArgs e)
        {
            if (txtServico.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarServicoNome();
                MostrarImagem();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarServicoNome();
                MostrarImagem();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtServico.Enabled = false;
                CarregarServicoStatus();
                MostrarImagem();
            }
            else
            {
                txtServico.Enabled = true;
                CarregarServicoNome();
                MostrarImagem();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadServico().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadServico().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha da tabela.");
            }
            MessageBox.Show(Variaveis.linhaSelecionada.ToString());
        }

        private void dgvServico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if(Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codServico = Convert.ToInt32(dgvServico[1, Variaveis.linhaSelecionada].Value);

                //MessageBox.Show("Linha: " + Variaveis.linhaSelecionada + "\n Código: " + Variaveis.codServico);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {

                var resposta = MessageBox.Show("Deseja Mesmo Excluir?", "EXCLUIR", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    ExcluirServico();
                    CarregarServicoNome();
                    MostrarImagem();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha da tabela.");
            }
            MessageBox.Show(Variaveis.linhaSelecionada.ToString());
        }

       
    }
}
