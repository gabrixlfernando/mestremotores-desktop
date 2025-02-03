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
    public partial class frmNoticia : Form
    {

        private PictureBox pctNoticia = new PictureBox();
        public frmNoticia()
        {
            InitializeComponent();
            pctNoticia.SizeMode = PictureBoxSizeMode.StretchImage;
            pctNoticia.BorderStyle = BorderStyle.FixedSingle;
            pctNoticia.Visible = false;
            pctNoticia.BackColor = Color.FromArgb(39, 50, 90);
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
                MostrarImagem();
                dgvNoticia.ClearSelection();

                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carregar as noticias. " + erro);
                throw;
            }
        }

        private void MostrarImagem()
        {
            string caminhoBase = @"C:\xampp\htdocs\ti26\mestremotores\";

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.HeaderText = "FOTO";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvNoticia.Columns.Insert(0, imgColumn);

            foreach (DataGridViewRow row in dgvNoticia.Rows)
            {
                if (row.Cells["foto_noticia"].Value != DBNull.Value)
                {
                    string caminhoRelativo = row.Cells["foto_noticia"].Value.ToString();
                    string caminhoCompleto = Path.Combine(caminhoBase, caminhoRelativo);

                    if (File.Exists(caminhoCompleto))
                    {
                        row.Cells[0].Value = Image.FromFile(caminhoCompleto);
                    }
                    else
                    {
                        row.Cells[0].Value = Properties.Resources.btnNoticia;
                    }
                }
            }
        }


        private void frmNoticia_Load(object sender, EventArgs e)
        {
            CarregarNoticia();
        }

        private void dgvNoticia_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                var cell = dgvNoticia.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null && cell.Value is Image img)
                {
                    pctNoticia.Image = img;
                    pctNoticia.Visible = true;

                    pctNoticia.Location = new Point(dgvNoticia.Location.X + dgvNoticia.Width - 300, dgvNoticia.Location.Y);
                    pctNoticia.Width = 300;
                    pctNoticia.Height = 300;
                    this.Controls.Add(pctNoticia);
                    pctNoticia.BringToFront();
                }
            }
        }

        private void dgvNoticia_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                pctNoticia.Visible = false;
            }
        }
    }
}
