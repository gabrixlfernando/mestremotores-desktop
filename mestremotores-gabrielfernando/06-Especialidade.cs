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
        } private void CarregarEspecialidadeNome()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_especialidade WHERE nome_especialidade LIKE @nome ORDER BY nome_especialidade;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", "%" + txtEspecialidade.Text + "%");
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
        private void CarregarEspecialidadeStatus()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT * FROM tbl_especialidade WHERE status_especialidade = @status ORDER BY nome_especialidade;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
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

        private void ExcluirEspecialidade()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE tbl_especialidade SET status_especialidade = @status WHERE id_especialidade = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);
                cmd.Parameters.AddWithValue("@status", "DESATIVADO");
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codEspecialidade);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Especialidade excluído com sucesso!", "EXCLUIR ESPECIALIDADE");
                Banco.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao EXCLUIR Especialidade!\n\n" + erro, "ERRO");

            }
        }

        

     

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "ATIVO" || cmbStatus.Text == "INATIVO" || cmbStatus.Text == "DESATIVADO")
            {
                txtEspecialidade.Enabled = false;
                CarregarEspecialidadeStatus();
            }
            else
            {
                txtEspecialidade.Enabled = true;
                CarregarEspecialidade();
            }
        }

        private void txtEspecialidade_TextChanged(object sender, EventArgs e)
        {
            if (txtEspecialidade.Text.Length > 0)
            {
                cmbStatus.Enabled = false;
                CarregarEspecialidadeNome();

            }
            else
            {
                cmbStatus.Enabled = true;
                CarregarEspecialidade();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Variaveis.funcao = "CADASTRAR";
            new frmCadEspecialidade().Show();
            Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.funcao = "ALTERAR";
                new frmCadEspecialidade().Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Para alterar selecione uma linha da tabela.");
            }
            MessageBox.Show(Variaveis.linhaSelecionada.ToString());
        }

        private void dgvEspecialidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variaveis.linhaSelecionada = int.Parse(e.RowIndex.ToString());
            if (Variaveis.linhaSelecionada >= 0)
            {
                Variaveis.codEspecialidade = Convert.ToInt32(dgvEspecialidade[0, Variaveis.linhaSelecionada].Value);

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
                    ExcluirEspecialidade();
                    CarregarEspecialidadeNome();
                }
            }
            else
            {
                MessageBox.Show("Para excluir selecione uma linha da tabela.");
            }
            MessageBox.Show(Variaveis.linhaSelecionada.ToString());
        }

        private void frmEspecialidade_Load(object sender, EventArgs e)
        {
            CarregarEspecialidade();
        }
    }
}
