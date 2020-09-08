namespace ProjQuentinhas
{
    partial class ProdutosForm
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
            this.buttonExcluirProduto = new System.Windows.Forms.Button();
            this.buttonEditarProduto = new System.Windows.Forms.Button();
            this.buttonNovoProduto = new System.Windows.Forms.Button();
            this.textBoxProdutoPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProdutoComponente = new System.Windows.Forms.TextBox();
            this.textBoxProdutoId = new System.Windows.Forms.TextBox();
            this.textBoxProdutoNome = new System.Windows.Forms.TextBox();
            this.label_cpf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExcluirProduto
            // 
            this.buttonExcluirProduto.Location = new System.Drawing.Point(456, 224);
            this.buttonExcluirProduto.Name = "buttonExcluirProduto";
            this.buttonExcluirProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirProduto.TabIndex = 6;
            this.buttonExcluirProduto.Text = "Excluir";
            this.buttonExcluirProduto.UseVisualStyleBackColor = true;
            this.buttonExcluirProduto.Click += new System.EventHandler(this.buttonExcluirProduto_Click);
            // 
            // buttonEditarProduto
            // 
            this.buttonEditarProduto.Location = new System.Drawing.Point(356, 224);
            this.buttonEditarProduto.Name = "buttonEditarProduto";
            this.buttonEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarProduto.TabIndex = 5;
            this.buttonEditarProduto.Text = "Editar";
            this.buttonEditarProduto.UseVisualStyleBackColor = true;
            this.buttonEditarProduto.Click += new System.EventHandler(this.buttonEditarProduto_Click);
            // 
            // buttonNovoProduto
            // 
            this.buttonNovoProduto.Location = new System.Drawing.Point(251, 224);
            this.buttonNovoProduto.Name = "buttonNovoProduto";
            this.buttonNovoProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoProduto.TabIndex = 4;
            this.buttonNovoProduto.Text = "Novo";
            this.buttonNovoProduto.UseVisualStyleBackColor = true;
            this.buttonNovoProduto.Click += new System.EventHandler(this.buttonNovoProduto_Click);
            // 
            // textBoxProdutoPreco
            // 
            this.textBoxProdutoPreco.Location = new System.Drawing.Point(243, 157);
            this.textBoxProdutoPreco.Name = "textBoxProdutoPreco";
            this.textBoxProdutoPreco.Size = new System.Drawing.Size(142, 20);
            this.textBoxProdutoPreco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preço:";
            // 
            // textBoxProdutoComponente
            // 
            this.textBoxProdutoComponente.Location = new System.Drawing.Point(243, 131);
            this.textBoxProdutoComponente.Name = "textBoxProdutoComponente";
            this.textBoxProdutoComponente.Size = new System.Drawing.Size(142, 20);
            this.textBoxProdutoComponente.TabIndex = 2;
            // 
            // textBoxProdutoId
            // 
            this.textBoxProdutoId.Location = new System.Drawing.Point(243, 79);
            this.textBoxProdutoId.Name = "textBoxProdutoId";
            this.textBoxProdutoId.ReadOnly = true;
            this.textBoxProdutoId.Size = new System.Drawing.Size(44, 20);
            this.textBoxProdutoId.TabIndex = 16;
            // 
            // textBoxProdutoNome
            // 
            this.textBoxProdutoNome.Location = new System.Drawing.Point(243, 105);
            this.textBoxProdutoNome.Name = "textBoxProdutoNome";
            this.textBoxProdutoNome.Size = new System.Drawing.Size(249, 20);
            this.textBoxProdutoNome.TabIndex = 1;
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.Location = new System.Drawing.Point(163, 134);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(75, 13);
            this.label_cpf.TabIndex = 9;
            this.label_cpf.Text = "Componentes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "id:";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(119, 112);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(116, 13);
            this.label_nome.TabIndex = 11;
            this.label_nome.Text = "Tipo/Nome Quentinha:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(176, 273);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 21;
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
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonExcluirProduto);
            this.Controls.Add(this.buttonEditarProduto);
            this.Controls.Add(this.buttonNovoProduto);
            this.Controls.Add(this.textBoxProdutoPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProdutoComponente);
            this.Controls.Add(this.textBoxProdutoId);
            this.Controls.Add(this.textBoxProdutoNome);
            this.Controls.Add(this.label_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.dataGridView2);
            this.Name = "ProdutosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ProdutosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExcluirProduto;
        private System.Windows.Forms.Button buttonEditarProduto;
        private System.Windows.Forms.Button buttonNovoProduto;
        private System.Windows.Forms.TextBox textBoxProdutoPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProdutoComponente;
        private System.Windows.Forms.TextBox textBoxProdutoId;
        private System.Windows.Forms.TextBox textBoxProdutoNome;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}