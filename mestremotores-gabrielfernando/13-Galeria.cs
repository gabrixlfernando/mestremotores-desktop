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
    public partial class frmGaleria : Form
    {

        private PictureBox pctGaleria = new PictureBox();
        public frmGaleria()
        {
            InitializeComponent();
            pctGaleria.SizeMode = PictureBoxSizeMode.StretchImage;
            pctGaleria.BorderStyle = BorderStyle.FixedSingle;
            pctGaleria.Visible = false;
            pctGaleria.BackColor = Color.FromArgb(39, 50, 90);
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
                dgvGaleria.Columns[2].Visible = false;
                dgvGaleria.Columns[3].HeaderText = "ALT";
                dgvGaleria.Columns[4].HeaderText = "STATUS";
                MostrarImagem();
                dgvGaleria.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a galeria. " + erro);
                throw;
            }
        }private void CarregarGaleriaNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_galeria WHERE nome_galeria LIKE @nome ORDER BY nome_galeria;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + txtGaleria.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGaleria.DataSource = dt;
                dgvGaleria.Columns[0].Visible = false;
                dgvGaleria.Columns[1].HeaderText = "NOME";
                dgvGaleria.Columns[2].Visible = false;
                dgvGaleria.Columns[3].HeaderText = "ALT";
                dgvGaleria.Columns[4].HeaderText = "STATUS";
                MostrarImagem();
                dgvGaleria.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a galeria. " + erro);
                throw;
            }
        }private void CarregarGaleriaStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_galeria WHERE status_galeria = @status ORDER BY nome_galeria;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvGaleria.DataSource = dt;
                dgvGaleria.Columns[0].Visible = false;
                dgvGaleria.Columns[1].HeaderText = "NOME";
                dgvGaleria.Columns[2].Visible = false;
                dgvGaleria.Columns[3].HeaderText = "ALT";
                dgvGaleria.Columns[4].HeaderText = "STATUS";
                MostrarImagem();
                dgvGaleria.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar a galeria. " + erro);
                throw;
            }
        }

        private void MostrarImagem()
        {
            string caminhoBase = @"C:\xampp\htdocs\ti26\mestremotores\";

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "FOTO";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvGaleria.Columns.Insert(0, imgColumn);

            foreach (DataGridViewRow row in dgvGaleria.Rows)
            {
                if (row.Cells["foto_galeria"].Value != DBNull.Value)
                {
                    string caminhoRelativo = row.Cells["foto_galeria"].Value.ToString();
                    string caminhoCompleto = Path.Combine(caminhoBase, caminhoRelativo);

                    if (File.Exists(caminhoCompleto))
                    {
                        row.Cells[0].Value = Image.FromFile(caminhoCompleto);
                    }
                    else
                    {
                        row.Cells[0].Value = Properties.Resources.btnGaleria;
                    }
                }
            }
        }

        private void frmGaleria_Load(object sender, EventArgs e)
        {
            CarregarGaleria();
        }

        private void dgvGaleria_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var cell = dgvGaleria.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is Image img)
                {
                    pctGaleria.Image = img;
                    pctGaleria.Visible = true;

                    pctGaleria.Location = new Point(dgvGaleria.Location.X + dgvGaleria.Width - 300, dgvGaleria.Location.Y);
                    pctGaleria.Width = 300;
                    pctGaleria.Height = 300;
                    this.Controls.Add(pctGaleria);
                    pctGaleria.BringToFront();
                }
            }
        }

        private void dgvGaleria_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                pctGaleria.Visible = false;
            }
        }

        private void txtGaleria_TextChanged(object sender, EventArgs e)
        {
            if (txtGaleria.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarGaleriaNome();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarGaleria();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtGaleria.Enabled = false;
                CarregarGaleriaStatus();
            }
            else
            {
                txtGaleria.Enabled = true;
                CarregarGaleria();
            }
        }
    }
}
