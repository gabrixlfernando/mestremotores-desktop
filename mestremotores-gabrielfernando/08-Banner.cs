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
    public partial class frmBanner : Form
    {
        private PictureBox pctBanner = new PictureBox();
        public frmBanner()
        {
            InitializeComponent();
            pctBanner.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBanner.BorderStyle = BorderStyle.FixedSingle;
            pctBanner.Visible = false;
            pctBanner.BackColor = Color.FromArgb(39, 50, 90);
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
                dgvBanner.Columns[2].Visible = false;
                dgvBanner.Columns[3].HeaderText = "ALT";               
                dgvBanner.Columns[4].HeaderText = "STATUS";

                //MostrarImagem();
                dgvBanner.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os banners. " + erro);
                throw;
            }
        }private void CarregarBannerNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_banner WHERE nome_banner LIKE @nome ORDER BY nome_banner;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + txtBanner.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBanner.DataSource = dt;
                //dgvBanner.Columns[0].Visible = false;
                //dgvBanner.Columns[1].HeaderText = "NOME";
                //dgvBanner.Columns[2].Visible = false;
                //dgvBanner.Columns[3].HeaderText = "ALT";               
                //dgvBanner.Columns[4].HeaderText = "STATUS";

                //MostrarImagem();
                dgvBanner.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os banners. " + erro);
                throw;
            }
        }private void CarregarBannerStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_banner WHERE status_banner = @status ORDER BY nome_banner;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBanner.DataSource = dt;
                //dgvBanner.Columns[0].Visible = false;
                //dgvBanner.Columns[1].HeaderText = "NOME";
                //dgvBanner.Columns[2].Visible = false;
                //dgvBanner.Columns[3].HeaderText = "ALT";               
                //dgvBanner.Columns[4].HeaderText = "STATUS";

                //MostrarImagem();
                dgvBanner.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar os banners. " + erro);
                throw;
            }
        }

        private void MostrarImagem()
        {
            string caminhoBase = @"C:\xampp\htdocs\ti26\mestremotores\";
            string nomeColunaImagem = "colunaImagem";
            if (dgvBanner.Columns.Contains(nomeColunaImagem))
            {
                dgvBanner.Columns.Remove(nomeColunaImagem);
            }

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "FOTO";
            imgColumn.Name = nomeColunaImagem;
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvBanner.Columns.Insert(0, imgColumn);

            foreach (DataGridViewRow row in dgvBanner.Rows)
            {
                if (row.Cells["foto_banner"].Value != DBNull.Value)
                {
                    string caminhoRelativo = row.Cells["foto_banner"].Value.ToString();
                    string caminhoCompleto = Path.Combine(caminhoBase, caminhoRelativo);

                    if (File.Exists(caminhoCompleto))
                    {
                        row.Cells[0].Value = Image.FromFile(caminhoCompleto);
                    }
                    else
                    {
                        row.Cells[0].Value = Properties.Resources.btnBanner;
                    }
                }
            }
        }

        private void frmBanner_Load(object sender, EventArgs e)
        {
            CarregarBanner();
            MostrarImagem();
        }

        private void dgvBanner_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var cell = dgvBanner.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is Image img)
                {
                    pctBanner.Image = img;
                    pctBanner.Visible = true;

                    pctBanner.Location = new Point(dgvBanner.Location.X + dgvBanner.Width - 450, dgvBanner.Location.Y);
                    pctBanner.Width = 450;
                    pctBanner.Height = 300;
                    this.Controls.Add(pctBanner);
                    pctBanner.BringToFront();
                }
            }
        }

        private void dgvBanner_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                pctBanner.Visible = false;
            }
        }

        private void txtBanner_TextChanged(object sender, EventArgs e)
        {
            if (txtBanner.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarBannerNome();
                MostrarImagem();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarBannerNome();
                MostrarImagem();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtBanner.Enabled = false;
                CarregarBannerStatus();
                MostrarImagem();
            }
            else
            {
                txtBanner.Enabled = true;
                CarregarBannerNome();
                MostrarImagem();
            }
        }
    }
}
