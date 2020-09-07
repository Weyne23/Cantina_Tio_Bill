using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjQuentinhas.model
{
    class Produto
    {
        CONNECT conn = new CONNECT();

        // Funcão inserir um novo Produto
        public bool inserirProduto(string nome, string componentes, double preco)
        {
            MySqlCommand command = new MySqlCommand();
            string inserirQuery = "INSERT INTO `produtos`(`nome`, `componentes`, `preco`) VALUES (@nome,@componentes,@preco)";
            command.CommandText = inserirQuery;
            command.Connection = conn.getConnection();
            //@nome,@componentes,@preco
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@componentes", MySqlDbType.VarChar).Value = componentes;
            command.Parameters.Add("@preco", MySqlDbType.Double).Value = preco;            

            conn.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }

        //função para retornar a lista de produtos
        public DataTable listarProdutos()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `produtos`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }


        //função para editar produto
        public bool editarProduto(int id, string nome, string componentes, double preco)
        {
            MySqlCommand command = new MySqlCommand();
            string editarQuery = "UPDATE `produtos` SET `nome`=@nome,`componentes`=@componentes,`preco`=@preco WHERE `id`=@id";
            
            command.CommandText = editarQuery;
            command.Connection = conn.getConnection();

            //@id,@nome,@componentes,@preco
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@componentes", MySqlDbType.VarChar).Value = componentes;
            command.Parameters.Add("@preco", MySqlDbType.Double).Value = preco;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }

        // função para deletar produto
        // usando apenas o id do produto

        public bool excluirProduto(int id)
        {
            MySqlCommand command = new MySqlCommand();
            string excluirQuery = "DELETE FROM `produtos` WHERE `id`=@id";

            command.CommandText = excluirQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {

                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

    }
}
