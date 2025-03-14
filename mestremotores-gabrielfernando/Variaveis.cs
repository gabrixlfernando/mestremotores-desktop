using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mestremotores_gabrielfernando
{
    public static class Variaveis
    {
        //GERAL
        public static string funcao;
        public static int linhaSelecionada;

        //CLIENTE
        public static int codCliente;
        public static string nomeCliente, cpfCliente, enderecoCliente, bairroCliente, cidadeCliente, estadoCliente, telefoneCliente, emailCliente, senhaCliente, statusCliente;
        public static DateTime dataCadCliente;

        //FUNCIONARIO
        public static int codFuncionario;
        public static string nomeFuncionario, cpfFuncionario, enderecoFuncionario, bairroFuncionario, cidadeFuncionario, estadoFuncionario, telefoneFuncionario, emailFuncionario, senhaFuncionario, statusFuncionario;
        public static DateTime dataCadFuncionario;

        //SERVIÇO
        public static int codServico;
        public static string nomeServico, descricaoServico, fotoServico, caminhoFotoServico, atFotoServico, altServico,tipoServico, statusServico;
        public static double valorServico;
        public static TimeSpan duracaoServico;


        //ESPECIALIDADE
        public static int codEspecialidade;
        public static string nomeEspecialidade, statusEspecialidade;

        //FTP
        public static string enderecoServidorFtp = "ftp://127.0.0.1/";
        public static string usuarioFtp= "ti26";
        public static string senhaFtp = "123";


       


    }
}
