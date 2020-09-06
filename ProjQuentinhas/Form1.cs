using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjQuentinhas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`= @usn AND `password`= @pass";


            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn",  MySqlDbType.VarChar).Value = textBoxLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value =  textBoxPass.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                // Mostrar o main_form
                this.Hide();
                MainForm mform = new MainForm();
                mform.Show();
            }
            else
            {
                if (textBoxLogin.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Entre com seu usuário para fazer o login", "Campo Usuário vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPass.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Entre com sua senha para fazer o login", "Campo Senha vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Este Usuário ou Senha não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
