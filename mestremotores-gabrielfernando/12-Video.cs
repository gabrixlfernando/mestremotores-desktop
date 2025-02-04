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

namespace mestremotores_gabrielfernando
{
    public partial class frmVideo : Form
    {
        private PictureBox pctVideo = new PictureBox();
        public frmVideo()
        {
            InitializeComponent();
            pctVideo.SizeMode = PictureBoxSizeMode.StretchImage;
            pctVideo.BorderStyle = BorderStyle.FixedSingle;
            pctVideo.Visible = false;
            pctVideo.BackColor = Color.FromArgb(39, 50, 90);
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
                dgvVideo.Columns[3].HeaderText = "ALT";
                dgvVideo.Columns[4].HeaderText = "URL";               
                dgvVideo.Columns[5].HeaderText = "STATUS";
                //MostrarImagem();
                dgvVideo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os videos. " + erro);
                throw;
            }
        }private void CarregarVideoNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_video  WHERE nome_video LIKE @nome ORDER BY nome_video;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + txtVideo.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVideo.DataSource = dt;
                //dgvVideo.Columns[0].Visible = false;
                //dgvVideo.Columns[1].HeaderText = "NOME";
                //dgvVideo.Columns[2].Visible = false;
                //dgvVideo.Columns[3].HeaderText = "ALT";
                //dgvVideo.Columns[4].HeaderText = "URL";               
                //dgvVideo.Columns[5].HeaderText = "STATUS";
                //MostrarImagem();
                dgvVideo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os videos. " + erro);
                throw;
            }
        }private void CarregarVideoStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_video  WHERE status_video = @status ORDER BY nome_video;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvVideo.DataSource = dt;
                //dgvVideo.Columns[0].Visible = false;
                //dgvVideo.Columns[1].HeaderText = "NOME";
                //dgvVideo.Columns[2].Visible = false;
                //dgvVideo.Columns[3].HeaderText = "ALT";
                //dgvVideo.Columns[4].HeaderText = "URL";               
                //dgvVideo.Columns[5].HeaderText = "STATUS";
                //MostrarImagem();
                dgvVideo.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os videos. " + erro);
                throw;
            }
        }

        private void MostrarImagem()
        {
            string caminhoBase = @"C:\xampp\htdocs\ti26\mestremotores\";
            string nomeColunaImagem = "colunaImagem";
            if (dgvVideo.Columns.Contains(nomeColunaImagem))
            {
                dgvVideo.Columns.Remove(nomeColunaImagem);
            }

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "FOTO";
            imgColumn.Name = nomeColunaImagem;
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvVideo.Columns.Insert(0, imgColumn);

            foreach (DataGridViewRow row in dgvVideo.Rows)
            {
                if (row.Cells["foto_video"].Value != DBNull.Value)
                {
                    string caminhoRelativo = row.Cells["foto_video"].Value.ToString();
                    string caminhoCompleto = Path.Combine(caminhoBase, caminhoRelativo);

                    if (File.Exists(caminhoCompleto))
                    {
                        row.Cells[0].Value = Image.FromFile(caminhoCompleto);
                    }
                    else
                    {
                        row.Cells[0].Value = Properties.Resources.btnVideo;
                    }
                }
            }
        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            CarregarVideo();
            MostrarImagem();
        }

        private void dgvVideo_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var cell = dgvVideo.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is Image img)
                {
                    pctVideo.Image = img;
                    pctVideo.Visible = true;

                    pctVideo.Location = new Point(dgvVideo.Location.X + dgvVideo.Width - 300, dgvVideo.Location.Y);
                    pctVideo.Width = 300;
                    pctVideo.Height = 300;
                    this.Controls.Add(pctVideo);
                    pctVideo.BringToFront();
                }
            }
        }

        private void dgvVideo_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                pctVideo.Visible = false;
            }
        }

        private void txtVideo_TextChanged(object sender, EventArgs e)
        {
            if (txtVideo.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarVideoNome();
                MostrarImagem();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarVideoNome();
                MostrarImagem();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtVideo.Enabled = false;
                CarregarVideoStatus();
                MostrarImagem();
            }
            else
            {
                txtVideo.Enabled = true;
                CarregarVideoNome();
                MostrarImagem();
            }
        }
    }
}
