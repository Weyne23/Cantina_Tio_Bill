using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjQuentinhas.model
{
    class Cliente
    {
        CONNECT conn = new CONNECT();

        // Funcão inserir um novo cliente
        public bool inserirCliente(string nome, string cpf, string contato, string data_nascimento, string endereco)
        {
            MySqlCommand command = new MySqlCommand();
            string inserirQuery = "INSERT INTO `cliente`(`nome`, `cpf`, `contato`, `data_nascimento`, `endereco`, `data_cadastro`, `total_pedidos`) VALUES (@nome, @cpf, @contato, @data_nascimento,   @endereco,  @data_cadastro, 0)";
            command.CommandText = inserirQuery;
            command.Connection = conn.getConnection();
            //@nome,@cpf,@contato,@data_nascimento,@endereco,@data_cadastro
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
            command.Parameters.Add("@contato", MySqlDbType.VarChar).Value = contato;
            command.Parameters.Add("@data_nascimento", MySqlDbType.DateTime).Value = DateTime.Parse(data_nascimento);
            command.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = endereco;
            command.Parameters.Add("@data_cadastro", MySqlDbType.DateTime).Value = DateTime.Now;

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

        //função para retornar a lista de clientes
        public DataTable listarClientes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `cliente`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //função para editar cliente
        public bool editarCliente (int id, string nome, string cpf, string contato, string data_nascimento, string endereco)
        {
            MySqlCommand command = new MySqlCommand();
            string editarQuery = "UPDATE `cliente` SET `nome`=@nome,`cpf`=@cpf,`contato`=@contato,`data_nascimento`=@data_nascimento,`endereco`=@endereco WHERE `id`=@id";

            command.CommandText = editarQuery;
            command.Connection = conn.getConnection();

            //@nome,@cpf,@contato,@data_nascimento,@endereco,@data_cadastro
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
            command.Parameters.Add("@contato", MySqlDbType.VarChar).Value = contato;
            command.Parameters.Add("@data_nascimento", MySqlDbType.DateTime).Value = DateTime.Parse(data_nascimento);
            command.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = endereco;
            

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

        // função para deletar cliente
        // usando apenas o id do cliente

        public bool excluirCliente(int id)
        {
            MySqlCommand command = new MySqlCommand();
            string excluirQuery = "DELETE FROM `cliente` WHERE `id`=@id";

            command.CommandText = excluirQuery;
            command.Connection = conn.getConnection();

            //@nome,@cpf,@contato,@data_nascimento,@endereco,@data_cadastro
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
