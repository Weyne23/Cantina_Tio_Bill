namespace ProjQuentinhas
{
    partial class PedidosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBuscarCliente = new System.Windows.Forms.TextBox();
            this.buttonProcurarCliente = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPedidosNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPedidosContato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPedidosEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPedidosTaxaEntrega = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.quentinha_dbDataSet = new ProjQuentinhas.quentinha_dbDataSet();
            this.quentinhadbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ProjQuentinhas.quentinha_dbDataSetTableAdapters.clienteTableAdapter();
            this.textBoxPedidosProduto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPedidosValor = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonPedidosAdicionar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentinha_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentinhadbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciador de Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(800, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pedidos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Cliente:";
            // 
            // textBoxBuscarCliente
            // 
            this.textBoxBuscarCliente.Location = new System.Drawing.Point(530, 104);
            this.textBoxBuscarCliente.Name = "textBoxBuscarCliente";
            this.textBoxBuscarCliente.Size = new System.Drawing.Size(134, 20);
            this.textBoxBuscarCliente.TabIndex = 37;
            // 
            // buttonProcurarCliente
            // 
            this.buttonProcurarCliente.Location = new System.Drawing.Point(552, 130);
            this.buttonProcurarCliente.Name = "buttonProcurarCliente";
            this.buttonProcurarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonProcurarCliente.TabIndex = 38;
            this.buttonProcurarCliente.Text = "procurar";
            this.buttonProcurarCliente.UseVisualStyleBackColor = true;
            this.buttonProcurarCliente.Click += new System.EventHandler(this.buttonProcurarCliente_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.AllowUserToAddRows = false;
            this.dataGridViewCliente.AllowUserToDeleteRows = false;
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(408, 159);
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.Size = new System.Drawing.Size(366, 150);
            this.dataGridViewCliente.TabIndex = 39;
            this.dataGridViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cliente:";
            // 
            // textBoxPedidosNome
            // 
            this.textBoxPedidosNome.Location = new System.Drawing.Point(134, 165);
            this.textBoxPedidosNome.Name = "textBoxPedidosNome";
            this.textBoxPedidosNome.Size = new System.Drawing.Size(215, 20);
            this.textBoxPedidosNome.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Contato:";
            // 
            // textBoxPedidosContato
            // 
            this.textBoxPedidosContato.Location = new System.Drawing.Point(134, 191);
            this.textBoxPedidosContato.Name = "textBoxPedidosContato";
            this.textBoxPedidosContato.Size = new System.Drawing.Size(134, 20);
            this.textBoxPedidosContato.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Endereço:";
            // 
            // textBoxPedidosEndereco
            // 
            this.textBoxPedidosEndereco.Location = new System.Drawing.Point(134, 216);
            this.textBoxPedidosEndereco.Name = "textBoxPedidosEndereco";
            this.textBoxPedidosEndereco.Size = new System.Drawing.Size(247, 20);
            this.textBoxPedidosEndereco.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Taxe de entrega:";
            // 
            // textBoxPedidosTaxaEntrega
            // 
            this.textBoxPedidosTaxaEntrega.Location = new System.Drawing.Point(134, 245);
            this.textBoxPedidosTaxaEntrega.Name = "textBoxPedidosTaxaEntrega";
            this.textBoxPedidosTaxaEntrega.Size = new System.Drawing.Size(103, 20);
            this.textBoxPedidosTaxaEntrega.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Lista de pedidos:";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(408, 346);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.Size = new System.Drawing.Size(366, 150);
            this.dataGridViewProdutos.TabIndex = 40;
            this.dataGridViewProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProdutos_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Lista de produtos";
            // 
            // quentinha_dbDataSet
            // 
            this.quentinha_dbDataSet.DataSetName = "quentinha_dbDataSet";
            this.quentinha_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quentinhadbDataSetBindingSource
            // 
            this.quentinhadbDataSetBindingSource.DataSource = this.quentinha_dbDataSet;
            this.quentinhadbDataSetBindingSource.Position = 0;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.quentinhadbDataSetBindingSource;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPedidosProduto
            // 
            this.textBoxPedidosProduto.Location = new System.Drawing.Point(464, 528);
            this.textBoxPedidosProduto.Name = "textBoxPedidosProduto";
            this.textBoxPedidosProduto.Size = new System.Drawing.Size(82, 20);
            this.textBoxPedidosProduto.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Produto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(559, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Valor:";
            // 
            // textBoxPedidosValor
            // 
            this.textBoxPedidosValor.Location = new System.Drawing.Point(599, 528);
            this.textBoxPedidosValor.Name = "textBoxPedidosValor";
            this.textBoxPedidosValor.Size = new System.Drawing.Size(82, 20);
            this.textBoxPedidosValor.TabIndex = 37;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(43, 346);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(306, 158);
            this.textBoxResult.TabIndex = 41;
            // 
            // buttonPedidosAdicionar
            // 
            this.buttonPedidosAdicionar.Location = new System.Drawing.Point(699, 525);
            this.buttonPedidosAdicionar.Name = "buttonPedidosAdicionar";
            this.buttonPedidosAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonPedidosAdicionar.TabIndex = 42;
            this.buttonPedidosAdicionar.Text = "Adicionar";
            this.buttonPedidosAdicionar.UseVisualStyleBackColor = true;
            this.buttonPedidosAdicionar.Click += new System.EventHandler(this.buttonPedidosAdicionar_Click);
            // 
            // PedidosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.buttonPedidosAdicionar);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.buttonProcurarCliente);
            this.Controls.Add(this.textBoxPedidosValor);
            this.Controls.Add(this.textBoxPedidosProduto);
            this.Controls.Add(this.textBoxPedidosTaxaEntrega);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPedidosEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPedidosContato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPedidosNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBuscarCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PedidosForm";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.PedidosForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentinha_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quentinhadbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBuscarCliente;
        private System.Windows.Forms.Button buttonProcurarCliente;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPedidosNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPedidosContato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPedidosEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPedidosTaxaEntrega;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource quentinhadbDataSetBindingSource;
        private quentinha_dbDataSet quentinha_dbDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private quentinha_dbDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TextBox textBoxPedidosProduto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPedidosValor;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonPedidosAdicionar;
    }
}