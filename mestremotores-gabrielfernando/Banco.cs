using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace mestremotores_gabrielfernando
{
    public static class Banco
    {
        //public static string db = "SERVER=localhost;USER=root;DATABASE=mestremotores";

        public static string db = "SERVER=smpsistema.com.br;USER=u283879542_gabriel_f;PASSWORD=@Ti26_06;DATABASE=u283879542_gabriel_f;SSL MODE=None";

        public static MySqlConnection conexao;

        public static void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Open();
            }
            catch
            {

                MessageBox.Show("Erro ao acessar o BANCO DE DADOS.");
            }

        }

        public static void Desconectar()
        {
            try
            {
                conexao = new MySqlConnection(db);
                conexao.Close();
            }
            catch
            {

                MessageBox.Show("Erro ao desconectar o BANCO DE DADOS.");
            }

        }



    }
}
