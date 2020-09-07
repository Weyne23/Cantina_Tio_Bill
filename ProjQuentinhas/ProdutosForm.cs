using ProjQuentinhas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjQuentinhas
{
    public partial class ProdutosForm : Form
    {
        Produto produto = new Produto();

        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            textBoxProdutoId.Text = "";
            textBoxProdutoNome.Text = "";
            textBoxProdutoComponente.Text = "";
            textBoxProdutoPreco.Text = "";
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNovoProduto_Click(object sender, EventArgs e)
        {
            //`nome`, `componentes`, `preco`

            string nome = textBoxProdutoNome.Text;
            string componentes = textBoxProdutoComponente.Text;
            string preco = textBoxProdutoPreco.Text;


            if (nome.Trim().Equals("") || componentes.Trim().Equals("") || preco.Trim().Equals(""))
            {
                MessageBox.Show("Preencha todos os campos", "Campos vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Boolean inserirProduto = produto.inserirProduto(nome, componentes, double.Parse(preco, CultureInfo.InvariantCulture));

                if (inserirProduto)
                {
                    dataGridView2.DataSource = produto.listarProdutos();
                    limparCampos();
                    MessageBox.Show("Produto inserido com sucesso", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao inserir o produto", "Adicionar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // `id` `nome`, `cpf`, `contato`, `data_nascimento`, `endereco`
            textBoxProdutoId.Text         = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBoxProdutoNome.Text       = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBoxProdutoComponente.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBoxProdutoPreco.Text      = dataGridView2.CurrentRow.Cells[3].Value.ToString();            
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = produto.listarProdutos();
        }

        private void buttonEditarProduto_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxProdutoId.Text);
            string nome = textBoxProdutoNome.Text;
            string componentes = textBoxProdutoComponente.Text;
            string preco = textBoxProdutoPreco.Text;



            if (nome.Trim().Equals("") || componentes.Trim().Equals("") || preco.Trim().Equals(""))
            {
                MessageBox.Show("Preencha todos os campos", "Campos vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean editarProduto = produto.editarProduto(id, nome, componentes, double.Parse(preco, CultureInfo.InvariantCulture));

                if (editarProduto)
                {
                    dataGridView2.DataSource = produto.listarProdutos();
                    limparCampos();
                    MessageBox.Show("Produto Editado com sucesso", "Editar Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao editar o produto", "Editar Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonExcluirProduto_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxProdutoId.Text);

                if (produto.excluirProduto(id))
                {
                    dataGridView2.DataSource = produto.listarProdutos();
                    limparCampos();
                    MessageBox.Show("Produto excluido com sucesso", "Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o produto", "Excluir Produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
