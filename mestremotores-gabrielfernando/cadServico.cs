using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mestremotores_gabrielfernando
{
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmServico().Show();
            Close();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtValor.Focus();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskDuração.Focus();
            }
        }

        private void mskDuração_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtTipo.Focus();
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbEspecialidade.Focus();
            }
        }

        private void cmbEspecialidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cmbStatus.Focus();
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFoto.Focus();
            }
        }

        private void btnFoto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtValor.Clear();
            mskDuração.Clear();
            txtTipo.Clear();
            cmbEspecialidade.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            pctFoto.Image = null;

            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text.Length == 0)
            {
                MessageBox.Show("Preencha Nome.");
                txtNome.Focus();
            }
            else if (txtDescricao.Text.Length == 0)
            {
                MessageBox.Show("Preencha Descrição.");
                txtDescricao.Focus();
            }
            else if(txtValor.Text.Length == 0)
            {
                MessageBox.Show("Preencha Valor.");
                txtValor.Focus();

            }
            else if (mskDuração.MaskCompleted == false)
            {
                MessageBox.Show("Preencha a duração.");
                mskDuração.Focus();
            }
            else if(txtTipo.Text.Length == 0)
            {
                MessageBox.Show("Preencha o tipo.");
                txtTipo.Focus();
            }
            else if(cmbEspecialidade.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha a especialidade.");
                cmbEspecialidade.Focus();
            }
            else if(cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha o Status.");
                cmbStatus.Focus();
            }
            else
            {

            }
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            lblFuncao.Text = "CADASTRAR";
        }
    }
}
