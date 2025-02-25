using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mestremotores_gabrielfernando
{
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        //Validação FTP

        private bool ValidarFTP()
        {
            if(string.IsNullOrEmpty(Variaveis.enderecoServidorFtp) || string.IsNullOrEmpty(Variaveis.usuarioFtp) || string.IsNullOrEmpty(Variaveis.senhaFtp))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Conversão IMG -> Byte
        public byte[] GetImgToByte(string caminhoArquivoFtp)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(Variaveis.usuarioFtp, Variaveis.senhaFtp);
            byte[] imageToByte = ftpClient.DownloadData(caminhoArquivoFtp);
            return imageToByte;
        }

        //Conversão byte -> img
        private static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream memoryStream = new MemoryStream();
            byte[] pData = blob;
            memoryStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bmp = new Bitmap(memoryStream, false);
            memoryStream.Dispose();
            return bmp;
            
        }

        private void InserirServico()
        {
            try
            {
                Banco.Conectar();
                string inserir= "INSERT INTO tbl_servico (nome_servico, descricao_servico, valor_servico, tempo_exec_servico, alt_servico, tipo_servico, id_especialidade, status_servico, foto_servico) VALUES (@nome, @descricao, @valor, @duracao, @alt, @tipo, @codEspecialidade, @status, @foto);";
                MySqlCommand cmd = new MySqlCommand(inserir,Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeServico);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descricaoServico);
                cmd.Parameters.AddWithValue("@valor", Variaveis.valorServico);
                cmd.Parameters.AddWithValue("@duracao", Variaveis.duracaoServico.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@alt", Variaveis.altServico);
                cmd.Parameters.AddWithValue("@tipo", Variaveis.tipoServico);
                cmd.Parameters.AddWithValue("@codEspecialidade", Variaveis.codEspecialidade);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusServico);
                cmd.Parameters.AddWithValue("@foto", Variaveis.fotoServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço cadastrado com sucesso!", "CADASTRO SERVIÇO");
                Banco.Desconectar();


                //Estrutura pra foto
                if (ValidarFTP())
                {
                    if(!string.IsNullOrEmpty(Variaveis.fotoServico))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "servico/" + Path.GetFileName(Variaveis.fotoServico);

                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoServico, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch 
                        {

                            MessageBox.Show("Foto não selecionada ou foto já existente!");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao cadastrar Serviço!\n\n" + erro, "ERRO");
                
            }
        }
        
        private void AlterarServico()
        {
            try
            {
                Banco.Conectar();
                string alterar= "UPDATE tbl_servico SET nome_servico = @nome, descricao_servico = @descricao, valor_servico = @valor, tempo_exec_servico = @duracao, alt_servico = @alt, tipo_servico = @tipo, id_especialidade = @codEspecialidade, status_servico = @status WHERE id_servico = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar,Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeServico);
                cmd.Parameters.AddWithValue("@descricao", Variaveis.descricaoServico);
                cmd.Parameters.AddWithValue("@valor", Variaveis.valorServico);
                cmd.Parameters.AddWithValue("@duracao", Variaveis.duracaoServico.ToString("HH:mm"));
                cmd.Parameters.AddWithValue("@alt", Variaveis.altServico);
                cmd.Parameters.AddWithValue("@tipo", Variaveis.tipoServico);
                cmd.Parameters.AddWithValue("@codEspecialidade", Variaveis.codEspecialidade);
                cmd.Parameters.AddWithValue("@status", Variaveis.statusServico);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço alterado com sucesso!", "ALTERAR SERVIÇO");
                Banco.Desconectar();


                //Estrutura pra foto
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao alterar Serviço!\n\n" + erro, "ERRO");
                
            }
        }

        private void AlterarFotoServico()
        {
            try
            {
                Banco.Conectar();
                string alterar = "UPDATE tbl_servico SET foto_servico = @foto WHERE id_servico = @codigo;";
                MySqlCommand cmd = new MySqlCommand(alterar, Banco.conexao);

                cmd.Parameters.AddWithValue("@foto", Variaveis.fotoServico);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Serviço alterado com sucesso!", "ALTERAR SERVIÇO");
                Banco.Desconectar();


                //Estrutura pra foto
                if (ValidarFTP())
                {
                    if (!string.IsNullOrEmpty(Variaveis.fotoServico))
                    {
                        string urlEnviarArquivo = Variaveis.enderecoServidorFtp + "servico/" + Path.GetFileName(Variaveis.fotoServico);

                        try
                        {
                            ftp.EnviarArquivoFtp(Variaveis.caminhoFotoServico, urlEnviarArquivo, Variaveis.usuarioFtp, Variaveis.senhaFtp);
                        }
                        catch
                        {

                            MessageBox.Show("Foto não selecionada ou foto já existente!");
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao alterar Serviço!\n\n" + erro, "ERRO");

            }
        }

        private void CarregarDadosServico()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT id_servico, nome_servico, descricao_servico, valor_servico, tempo_exec_servico, alt_servico, tipo_servico, nome_especialidade, status_servico, foto_servico FROM tbl_servico s INNER JOIN tbl_especialidade e ON s.id_especialidade = e.id_especialidade WHERE id_servico = @codigo;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", Variaveis.codServico);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Variaveis.nomeServico = dr.GetString(1);
                    Variaveis.descricaoServico = dr.GetString(2);
                    Variaveis.valorServico = dr.GetDouble(3);
                    //Variaveis.duracaoServico = Convert.ToDateTime(dr.GetString(4));
                    Variaveis.altServico = dr.GetString(5);
                    Variaveis.tipoServico = dr.GetString(6);
                    Variaveis.nomeEspecialidade = dr.GetString(7);
                    Variaveis.statusServico = dr.GetString(8);
                    Variaveis.fotoServico = dr.GetString(9);
                    Variaveis.fotoServico = Variaveis.fotoServico.Remove(0, 8);

                    txtNome.Text = Variaveis.nomeServico;
                    txtDescricao.Text = Variaveis.descricaoServico;
                    txtValor.Text = Variaveis.valorServico.ToString("N2");
                    //mskDuração.Text = Variaveis.duracaoServico.ToString();
                    txtTipo.Text = Variaveis.tipoServico;
                    cmbEspecialidade.Text = Variaveis.nomeEspecialidade;
                    cmbStatus.Text = Variaveis.statusServico;
                    pctFoto.Image = ByteToImage(GetImgToByte(Variaveis.enderecoServidorFtp + "servico/" + Variaveis.fotoServico));


                }
                Banco.Desconectar();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro ao carregar os dados do serviço" + erro, "ERRO");
            }
        }

        private void CarregarEspecialidade()
        {
            try
            {
                Banco.Conectar();
                string selecionar = "SELECT id_especialidade, nome_especialidade FROM tbl_especialidade ORDER BY nome_especialidade;";
                MySqlCommand cmd = new MySqlCommand(selecionar, Banco.conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbEspecialidade.DataSource = dt;
                cmbEspecialidade.DisplayMember = "nome_especialidade";
                cmbEspecialidade.ValueMember = "id_especialidade";
                cmbEspecialidade.SelectedIndex = -1;


                Banco.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao carrecar especialidades. " + erro);
                throw;
            }
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

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = false;
                ofd.FileName = "";
                ofd.InitialDirectory = @"C:";
                ofd.Title = "SELECIONE UMA FOTO";
                ofd.Filter = "JPG ou PNG(*.jpg ou *.png)|*.jpg;*.png";
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.RestoreDirectory = true;

                DialogResult dr = ofd.ShowDialog();
                pctFoto.Image = Image.FromFile(ofd.FileName);
                Variaveis.fotoServico = "servico/" + Regex.Replace(txtNome.Text, @"\s", "_").ToLower() + ".png";

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Variaveis.atFotoServico = "S";
                        Variaveis.caminhoFotoServico = ofd.FileName;
                    }
                    catch (SecurityException erro)
                    {

                        MessageBox.Show("Erro de segurança, fale com o ADMIN; \n" + erro.Message + "\nDetalhe:\n" + erro.StackTrace);
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Você não tem permissão para imagens." + erro);
                    }
                }
                btnSalvar.Focus();
            }
            catch (Exception erro)
            {

                throw erro;
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
            lblNome.ForeColor = Color.White;
            lblDescricao.ForeColor = Color.White;
            lblValor.ForeColor = Color.White;
            lblDuracao.ForeColor = Color.White;
            lblTipo.ForeColor = Color.White;
            lblEspecialidade.ForeColor = Color.White;
            lblStatus.ForeColor = Color.White;


            if(txtNome.Text.Length == 0)
            {
                lblNome.ForeColor = Color.Red;
                MessageBox.Show("Preencha Nome.");
                txtNome.Focus();
            }
            else if (txtDescricao.Text.Length == 0)
            {
                lblDescricao.ForeColor = Color.Red;
                MessageBox.Show("Preencha Descrição.");
                txtDescricao.Focus();
            }
            else if(txtValor.Text.Length == 0)
            {
                lblValor.ForeColor = Color.Red;
                MessageBox.Show("Preencha Valor.");
                txtValor.Focus();

            }
            else if (mskDuração.MaskCompleted == false)
            {
                lblDuracao.ForeColor = Color.Red;
                MessageBox.Show("Preencha a duração.");
                mskDuração.Focus();
            }
            else if(txtTipo.Text.Length == 0)
            {
                lblTipo.ForeColor = Color.Red;
                MessageBox.Show("Preencha o tipo.");
                txtTipo.Focus();
            }
            else if (cmbEspecialidade.SelectedIndex < 0)
            {
                lblEspecialidade.ForeColor = Color.Red;
                MessageBox.Show("Preencha a especialidade.");
                cmbEspecialidade.Focus();
            }
            else if(cmbStatus.SelectedIndex < 0)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Preencha o Status.");
                cmbStatus.Focus();
            }
            else
            {
                Variaveis.nomeServico = txtNome.Text;
                Variaveis.descricaoServico = txtDescricao.Text;
                Variaveis.valorServico = double.Parse(txtValor.Text);
                Variaveis.duracaoServico = DateTime.Parse(mskDuração.Text);
                Variaveis.altServico = txtNome.Text.ToLower();
                Variaveis.tipoServico = txtTipo.Text;
                Variaveis.codEspecialidade = Convert.ToInt32(cmbEspecialidade.SelectedValue);
                Variaveis.statusServico = cmbStatus.Text;

                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirServico();
                    Variaveis.funcao = "";
                }
                else if(Variaveis.funcao == "ALTERAR")
                {
                    AlterarServico();
                    if (Variaveis.atFotoServico == "S")
                    {
                        AlterarFotoServico();
                    }
                }
            }
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            lblFuncao.Text = Variaveis.funcao;
            CarregarEspecialidade();
            if (Variaveis.funcao == "ALTERAR")
            {
                CarregarDadosServico();
            }
        }

       
    }
}
