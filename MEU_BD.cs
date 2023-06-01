using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace StudentManager
{
    internal class MEU_BD
    {
        // |"conxao" é o OBJETO que REPRESENTA a conexão com o banco de dados.
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=sga_estudantes_bd");

        //Versão publica da variável/objeto "conexao"
        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }

        //Método para ABRIR/INICIALIZAR an conexão
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        //Método para FECHAR/ENCERAR an conexão
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
