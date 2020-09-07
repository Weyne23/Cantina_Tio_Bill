namespace ProjQuentinhas
{
    partial class ClientesForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExcluirCliente = new System.Windows.Forms.Button();
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            this.buttonNovoCliente = new System.Windows.Forms.Button();
            this.textBoxContato = new System.Windows.Forms.TextBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label_data_nascimento = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label_cpf = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonExcluirCliente);
            this.panel1.Controls.Add(this.buttonEditarCliente);
            this.panel1.Controls.Add(this.buttonNovoCliente);
            this.panel1.Controls.Add(this.textBoxContato);
            this.panel1.Controls.Add(this.textBoxEndereco);
            this.panel1.Controls.Add(this.textBoxDataNascimento);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxCpf);
            this.panel1.Controls.Add(this.label_data_nascimento);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.label_cpf);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label_nome);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonExcluirCliente
            // 
            this.buttonExcluirCliente.Location = new System.Drawing.Point(442, 259);
            this.buttonExcluirCliente.Name = "buttonExcluirCliente";
            this.buttonExcluirCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirCliente.TabIndex = 4;
            this.buttonExcluirCliente.Text = "Excluir";
            this.buttonExcluirCliente.UseVisualStyleBackColor = true;
            this.buttonExcluirCliente.Click += new System.EventHandler(this.buttonExcluirCliente_Click);
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.Location = new System.Drawing.Point(342, 259);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarCliente.TabIndex = 4;
            this.buttonEditarCliente.Text = "Editar";
            this.buttonEditarCliente.UseVisualStyleBackColor = true;
            this.buttonEditarCliente.Click += new System.EventHandler(this.buttonEditarCliente_Click);
            // 
            // buttonNovoCliente
            // 
            this.buttonNovoCliente.Location = new System.Drawing.Point(237, 259);
            this.buttonNovoCliente.Name = "buttonNovoCliente";
            this.buttonNovoCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonNovoCliente.TabIndex = 4;
            this.buttonNovoCliente.Text = "Novo";
            this.buttonNovoCliente.UseVisualStyleBackColor = true;
            this.buttonNovoCliente.Click += new System.EventHandler(this.buttonNovoCliente_Click);
            // 
            // textBoxContato
            // 
            this.textBoxContato.Location = new System.Drawing.Point(205, 160);
            this.textBoxContato.Name = "textBoxContato";
            this.textBoxContato.Size = new System.Drawing.Size(142, 20);
            this.textBoxContato.TabIndex = 3;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(205, 212);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(142, 20);
            this.textBoxEndereco.TabIndex = 3;
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.Location = new System.Drawing.Point(205, 186);
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.Size = new System.Drawing.Size(142, 20);
            this.textBoxDataNascimento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(205, 134);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(142, 20);
            this.textBoxCpf.TabIndex = 3;
            // 
            // label_data_nascimento
            // 
            this.label_data_nascimento.AutoSize = true;
            this.label_data_nascimento.Location = new System.Drawing.Point(94, 189);
            this.label_data_nascimento.Name = "label_data_nascimento";
            this.label_data_nascimento.Size = new System.Drawing.Size(105, 13);
            this.label_data_nascimento.TabIndex = 2;
            this.label_data_nascimento.Text = "Data de nascimento:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(205, 108);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(249, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // label_cpf
            // 
            this.label_cpf.AutoSize = true;
            this.label_cpf.Location = new System.Drawing.Point(169, 141);
            this.label_cpf.Name = "label_cpf";
            this.label_cpf.Size = new System.Drawing.Size(30, 13);
            this.label_cpf.TabIndex = 2;
            this.label_cpf.Text = "CPF:";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(161, 111);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(38, 13);
            this.label_nome.TabIndex = 2;
            this.label_nome.Text = "Nome:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(626, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 0;
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
            this.label1.Text = "Gerenciador de Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "id:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(205, 82);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 3;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ClientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExcluirCliente;
        private System.Windows.Forms.Button buttonEditarCliente;
        private System.Windows.Forms.Button buttonNovoCliente;
        private System.Windows.Forms.TextBox textBoxDataNascimento;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label label_data_nascimento;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label_cpf;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBoxContato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label4;
    }
}