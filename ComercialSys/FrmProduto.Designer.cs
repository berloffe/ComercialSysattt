namespace ComercialSys
{
    partial class FrmProduto
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
            txtCategoria = new TextBox();
            txtDescricao = new TextBox();
            txtClasseDesconto = new TextBox();
            mskCodigo = new MaskedTextBox();
            mskValor = new MaskedTextBox();
            cmbUnidedeVendas = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnInserir = new Button();
            txtEstoqueMinimo = new TextBox();
            label7 = new Label();
            btnObterPorID = new Button();
            btnEditar = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtId = new MaskedTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(157, 202);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(190, 23);
            txtCategoria.TabIndex = 4;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(157, 102);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(190, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtClasseDesconto
            // 
            txtClasseDesconto.Location = new Point(158, 260);
            txtClasseDesconto.Name = "txtClasseDesconto";
            txtClasseDesconto.Size = new Size(190, 23);
            txtClasseDesconto.TabIndex = 6;
            // 
            // mskCodigo
            // 
            mskCodigo.Location = new Point(157, 73);
            mskCodigo.Mask = "0 000000 000000";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(190, 23);
            mskCodigo.TabIndex = 0;
            // 
            // mskValor
            // 
            mskValor.Location = new Point(157, 136);
            mskValor.Name = "mskValor";
            mskValor.Size = new Size(190, 23);
            mskValor.TabIndex = 2;
            // 
            // cmbUnidedeVendas
            // 
            cmbUnidedeVendas.FormattingEnabled = true;
            cmbUnidedeVendas.Items.AddRange(new object[] { "1 - METRO", "2 - UNIDADE", "3 - QUILOGRAMA", "4 - LITRO", "5 - CAIXA ", "6 - MILILITRO", "7 - PEÇA ", "8 - FARDO", "9 - FRASCO", "10 - PACOTE", "11 - GRAMA" });
            cmbUnidedeVendas.Location = new Point(157, 168);
            cmbUnidedeVendas.Name = "cmbUnidedeVendas";
            cmbUnidedeVendas.Size = new Size(190, 23);
            cmbUnidedeVendas.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 76);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 8;
            label1.Text = "Código de barras";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 105);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 139);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 10;
            label3.Text = "Valor unitário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 171);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 11;
            label4.Text = "Unidade de venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 210);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 12;
            label5.Text = "Categoria ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 234);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 13;
            label6.Text = "Estoque minimo";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(299, 295);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 30);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(157, 231);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(190, 23);
            txtEstoqueMinimo.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 263);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 14;
            label7.Text = "Classe de Desconto";
            // 
            // btnObterPorID
            // 
            btnObterPorID.Location = new Point(167, 295);
            btnObterPorID.Name = "btnObterPorID";
            btnObterPorID.Size = new Size(94, 30);
            btnObterPorID.TabIndex = 7;
            btnObterPorID.Text = "&Obter por ID";
            btnObterPorID.UseVisualStyleBackColor = true;
            btnObterPorID.Click += btnObterPorID_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(26, 295);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 30);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(txtEstoqueMinimo);
            groupBox1.Controls.Add(txtClasseDesconto);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(btnObterPorID);
            groupBox1.Controls.Add(mskCodigo);
            groupBox1.Controls.Add(btnInserir);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(mskValor);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbUnidedeVendas);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(137, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 342);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 30);
            label8.Name = "label8";
            label8.Size = new Size(18, 15);
            label8.TabIndex = 8;
            label8.Text = "ID";
            label8.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(158, 30);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(64, 23);
            txtId.TabIndex = 2;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtCategoria;
        private TextBox txtDescricao;
        private TextBox txtClasseDesconto;
        private MaskedTextBox mskCodigo;
        private MaskedTextBox mskValor;
        private ComboBox cmbUnidedeVendas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnInserir;
        private TextBox txtEstoqueMinimo;
        private Label label7;
        private Button btnObterPorID;
        private Button btnEditar;
        private GroupBox groupBox1;
        private MaskedTextBox txtId;
        private Label label8;
    }
}