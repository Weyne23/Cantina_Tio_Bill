using ProjQuentinhas.model;
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
    public partial class ClientesForm: Form
    {
        Cliente cliente = new Cliente();
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            textBoxId.Text = "";
            textBoxNome.Text = "";
            textBoxCpf.Text = "";
            textBoxContato.Text = "";
            textBoxDataNascimento.Text = "";
            textBoxEndereco.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            //`nome`, `cpf`, `contato`, `data_nascimento`, `endereco`

            string nome = textBoxNome.Text;
            string cpf = textBoxCpf.Text;
            string contato = textBoxContato.Text;
            string data_nascimento = textBoxDataNascimento.Text;
            string endereco = textBoxEndereco.Text;
            

            if (nome.Trim().Equals("") || cpf.Trim().Equals("") || contato.Trim().Equals("") || data_nascimento.Trim().Equals("") || endereco.Trim().Equals(""))
            {
                MessageBox.Show("Preencha todos os campos", "Campos vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Boolean inserirCliente = cliente.inserirCliente(nome, cpf, contato, data_nascimento, endereco);

                if (inserirCliente)
                {
                    dataGridView1.DataSource = cliente.listarClientes();
                    limparCampos();
                    MessageBox.Show("Cliente inserido com sucesso", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir o cliente", "Adicionar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cliente.listarClientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string nome = textBoxNome.Text;
            string cpf = textBoxCpf.Text;
            string contato = textBoxContato.Text;
            string data_nascimento = textBoxDataNascimento.Text;
            string endereco = textBoxEndereco.Text;


            if (nome.Trim().Equals("") || cpf.Trim().Equals("") || contato.Trim().Equals("") || data_nascimento.Trim().Equals("") || endereco.Trim().Equals(""))
            {
                MessageBox.Show("Preencha todos os campos", "Campos vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Boolean editarCliente = cliente.editarCliente(id, nome, cpf, contato, data_nascimento, endereco);

                if (editarCliente)
                {
                    dataGridView1.DataSource = cliente.listarClientes();
                    limparCampos();
                    MessageBox.Show("Cliente Editado com sucesso", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao editar o cliente", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        // parte da tabela onde carregar os valores nos TextBoxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // `id` `nome`, `cpf`, `contato`, `data_nascimento`, `endereco`
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxCpf.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxContato.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxDataNascimento.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString().Substring(0, 10);
            textBoxEndereco.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }



        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBoxId.Text);



                if (cliente.excluirCliente(id))
                {
                    dataGridView1.DataSource = cliente.listarClientes();
                    limparCampos();
                    MessageBox.Show("Cliente excluido com sucesso", "Excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o cliente", "Excluir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }
    }
}
