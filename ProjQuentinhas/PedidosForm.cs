using ProjQuentinhas.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjQuentinhas
{
    public partial class PedidosForm : Form
    {

        Cliente cliente = new Cliente();
        Produto produto = new Produto();
        Pedidos pedidos = new Pedidos();

        public PedidosForm()
        {
            InitializeComponent();
        }

        private void PedidosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'quentinha_dbDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.quentinha_dbDataSet.cliente);
            dataGridViewProdutos.DataSource = produto.listarProdutos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            textBoxPedidosNome.Text = dataGridViewCliente.CurrentRow.Cells[1].Value.ToString();
            textBoxPedidosContato.Text = dataGridViewCliente.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonProcurarCliente_Click(object sender, EventArgs e)
        {
            string nome = textBoxBuscarCliente.Text;
            dataGridViewCliente.DataSource = cliente.listarClientesPorNome(nome);

        }

        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPedidosProduto.Text = dataGridViewProdutos.CurrentRow.Cells[1].Value.ToString();
            textBoxPedidosValor.Text = dataGridViewProdutos.CurrentRow.Cells[3].Value.ToString();
        }
        
        private void buttonPedidosAdicionar_Click(object sender, EventArgs e)
        {
            string nome = textBoxPedidosProduto.Text;
            string taxaEntrega = textBoxPedidosTaxaEntrega.Text;
            string valor = textBoxPedidosValor.Text;

            if (nome.Trim().Equals("") || taxaEntrega.Trim().Equals(""))
            {
                MessageBox.Show("Preencha todos os campos", "Campos vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                pedidos.Taxa_entrega = double.Parse(taxaEntrega, CultureInfo.InvariantCulture);
                pedidos.addProduto(new Produto(nome, double.Parse(textBoxPedidosValor.Text, CultureInfo.InvariantCulture)));
                

                textBoxResult.Text = pedidos.imprimeProdutos();
            }
              
        }

        private void buttonPedidosRemover_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(textBoxRemoveProduto.Text);
            pedidos.removeProduto(cod);


            textBoxResult.Text = pedidos.imprimeProdutos();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
