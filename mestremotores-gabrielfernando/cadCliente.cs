﻿using System;
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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            new frmCliente().Show();
            Close();
        }

        private void InserirCliente()
        {
            try
            {
                Banco.Conectar();
                string inserir = "INSERT INTO tbl_cliente (nome_cliente, cpf_cliente, endereco_cliente, bairro_cliente, cidade_cliente, estado_cliente, telefone_cliente, email_cliente, senha_cliente, data_cad_cliente, status_cliente) VALUES (@nome, @cpf, @endereco, @bairro, @cidade, @estado,@telefone, @email, @senha ,@dataCad ,@status);";
                MySqlCommand cmd = new MySqlCommand(inserir, Banco.conexao);
                cmd.Parameters.AddWithValue("@nome", Variaveis.nomeCliente);
                cmd.Parameters.AddWithValue("@cpf", Variaveis.cpfCliente);
                cmd.Parameters.AddWithValue("@endereco", Variaveis.enderecoCliente);
                cmd.Parameters.AddWithValue("@bairro", Variaveis.bairroCliente);
                cmd.Parameters.AddWithValue("@cidade", Variaveis.cidadeCliente);
                cmd.Parameters.AddWithValue("@estado", Variaveis.estadoCliente);
                cmd.Parameters.AddWithValue("@telefone", Variaveis.telefoneCliente);
                cmd.Parameters.AddWithValue("@email", Variaveis.emailCliente);
                cmd.Parameters.AddWithValue("@senha", Variaveis.senhaCliente);
                cmd.Parameters.AddWithValue("@dataCad", Variaveis.dataCadCliente.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@status", Variaveis.statusCliente);
               


                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!", "CADASTRO FUNCIONARIO");
                Banco.Desconectar();


                //Estrutura pra foto
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO ao cadastrar Cliente!\n\n" + erro, "ERRO");

            }
        }



        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskCPF.Focus();
            }
        }

        private void mskCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEndereco.Focus();
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtBairro.Focus();
            }
        }

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCidade.Focus();
            }
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEstado.Focus();
            }
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mskTelefone.Focus();
            }
        }

        private void mskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dtpDataCad.Focus();
            }
        }

        private void dtpDataCad_KeyPress(object sender, KeyPressEventArgs e)
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
                btnSalvar.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskCPF.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            mskTelefone.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            dtpDataCad.Value = DateTime.Today;
            cmbStatus.SelectedIndex = -1;
         

            txtNome.Focus();
        }




       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.White;
            lblCPF.ForeColor = Color.White;
            lblEndereco.ForeColor = Color.White;
            lblBairro.ForeColor = Color.White;
            lblCidade.ForeColor = Color.White;
            lblEstado.ForeColor = Color.White;
            lblTelefone.ForeColor = Color.White;
            lblEmail.ForeColor = Color.White;   
            lblSenha.ForeColor = Color.White;
            lblDataCad.ForeColor = Color.White;
            lblStatus.ForeColor = Color.White;

            if(txtNome.Text.Length == 0 )
            {
                lblNome.ForeColor = Color.Red;
                MessageBox.Show("Preencha Nome.");
                txtNome.Focus();
            }
            else if(mskCPF.Text.Length == 0 )
            {
                lblCPF.ForeColor = Color.Red;
                MessageBox.Show("Preencha CPF.");
                mskCPF.Focus();
            }
            else if (txtEndereco.Text.Length == 0)
            {
                lblEndereco.ForeColor = Color.Red;
                MessageBox.Show("Preencha Endereço.");
                txtEndereco.Focus();
            }
            else if(txtBairro.Text.Length == 0)
            {
                lblBairro.ForeColor = Color.Red;
                MessageBox.Show("Preencha Bairro.");
                txtBairro.Focus();
            }
            else if(txtCidade.Text.Length == 0)
            {
                lblCidade.ForeColor = Color.Red;
                MessageBox.Show("Preencha Cidade.");
                txtCidade.Focus();
            }
            else if(txtEstado.Text.Length == 0)
            {
                lblEstado.ForeColor = Color.Red;
                MessageBox.Show("Preencha Estado.");
                txtEstado.Focus();
            }
            else if(mskTelefone.Text.Length == 0)
            {
                lblTelefone.ForeColor = Color.Red;
                MessageBox.Show("Preencha Telefone.");
                mskTelefone.Focus();
            }
            else if( txtEmail.Text.Length == 0)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Preencha Email.");
                txtEmail.Focus();
            }
            else if(txtSenha.Text.Length == 0)
            {
                lblSenha.ForeColor = Color.Red;
                MessageBox.Show("Preencha Senha.");
                txtSenha.Focus();
            }
            else if(dtpDataCad.Text.Length == 0)
            {
                lblDataCad.ForeColor = Color.Red;
                MessageBox.Show("Preencha Data.");
                dtpDataCad.Focus();
            }
            else if (cmbStatus.Text.Length == 0)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Preencha Status.");
                cmbStatus.Focus();
            }
            else
            {

                Variaveis.nomeCliente = txtNome.Text;
                Variaveis.cpfCliente = mskCPF.Text;
                Variaveis.enderecoCliente = txtEndereco.Text;
                Variaveis.bairroCliente = txtBairro.Text;
                Variaveis.cidadeCliente = txtCidade.Text;
                Variaveis.estadoCliente = txtEstado.Text;
                Variaveis.telefoneCliente = mskTelefone.Text;
                Variaveis.emailCliente = txtEmail.Text;
                Variaveis.senhaCliente = txtSenha.Text;
                Variaveis.dataCadCliente = DateTime.Parse(dtpDataCad.Text);
                Variaveis.statusCliente = cmbStatus.Text;
               


                if (Variaveis.funcao == "CADASTRAR")
                {
                    InserirCliente();
                    Variaveis.funcao = "";
                }
                else if (Variaveis.funcao == "ALTERAR")
                {
                    //AlterarServico();
                }

            }
            
        }


        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            lblFuncao.Text = Variaveis.funcao;
        }
    }
}
