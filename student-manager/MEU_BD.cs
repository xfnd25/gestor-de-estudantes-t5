using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace student_manager
{
    internal class MEU_BD
    {
        // "conexao" é o objeto que representa a conexão com o
        // banco de dados
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=sga_estudantes_bd");
        //versão publica da variável/objeto "conexao"

        public MySqlConnection getConexao
        {
            get { return conexao; }
        }
        //metodo para abrir/inicializar a conexao
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }

        }

        //metodo para fechar/finalizar a conexao
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Close();
            }
        }
    }
}
