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
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(204, 205);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(190, 23);
            txtCategoria.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(204, 118);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(190, 23);
            txtDescricao.TabIndex = 0;
            // 
            // txtClasseDesconto
            // 
            txtClasseDesconto.Location = new Point(204, 263);
            txtClasseDesconto.Name = "txtClasseDesconto";
            txtClasseDesconto.Size = new Size(190, 23);
            txtClasseDesconto.TabIndex = 0;
            // 
            // mskCodigo
            // 
            mskCodigo.Location = new Point(204, 89);
            mskCodigo.Mask = "0 000000 000000";
            mskCodigo.Name = "mskCodigo";
            mskCodigo.Size = new Size(190, 23);
            mskCodigo.TabIndex = 1;
            // 
            // mskValor
            // 
            mskValor.Location = new Point(204, 147);
            mskValor.Mask = "000000.00";
            mskValor.Name = "mskValor";
            mskValor.Size = new Size(190, 23);
            mskValor.TabIndex = 2;
            // 
            // cmbUnidedeVendas
            // 
            cmbUnidedeVendas.FormattingEnabled = true;
            cmbUnidedeVendas.Items.AddRange(new object[] { "1 - METRO", "2 - UNIDADE", "3 - QUILOGRAMA", "4 - LITRO", "5 - CAIXA ", "6 - MILILITRO", "7 - PEÇA ", "8 - FARDO", "9 - FRASCO", "10 - PACOTE", "11 - GRAMA" });
            cmbUnidedeVendas.Location = new Point(204, 176);
            cmbUnidedeVendas.Name = "cmbUnidedeVendas";
            cmbUnidedeVendas.Size = new Size(190, 23);
            cmbUnidedeVendas.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 92);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 4;
            label1.Text = "Código de barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 126);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 150);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Valor unitário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(96, 184);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 7;
            label4.Text = "Unidade de venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 208);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 8;
            label5.Text = "Categoria ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 237);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 9;
            label6.Text = "Estoque minimo";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(254, 304);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 30);
            btnInserir.TabIndex = 10;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtEstoqueMinimo
            // 
            txtEstoqueMinimo.Location = new Point(204, 234);
            txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            txtEstoqueMinimo.Size = new Size(190, 23);
            txtEstoqueMinimo.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 266);
            label7.Name = "label7";
            label7.Size = new Size(109, 15);
            label7.TabIndex = 12;
            label7.Text = "Classe de Desconto";
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtEstoqueMinimo);
            Controls.Add(btnInserir);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUnidedeVendas);
            Controls.Add(mskValor);
            Controls.Add(mskCodigo);
            Controls.Add(txtDescricao);
            Controls.Add(txtClasseDesconto);
            Controls.Add(txtCategoria);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ResumeLayout(false);
            PerformLayout();
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
    }
}