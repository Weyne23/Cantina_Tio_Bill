using MySql.Data.MySqlClient;
using System.Data;


namespace ProjQuentinhas
{
    /*Classe que faz conexão com o banco*/
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=quentinha_db");

        /*Função que retorna a conexão*/

        public MySqlConnection getConnection()
        {
            return connection;
        }

        // Função para abrir a conexão
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open(); 
            }
        }

        // Função para fecha a conexão
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }





}
