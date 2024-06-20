namespace ComercialSys
{
    partial class FrmPedido
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txtNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtVendedor = new TextBox();
            btnAbrir = new Button();
            groupBox2 = new GroupBox();
            btnInserir = new Button();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtHashCode = new TextBox();
            txtDescricao = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnFinalizarP = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Cliente";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 35);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(362, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 24F);
            txtNumero.Location = new Point(685, 27);
            txtNumero.Name = "txtNumero";
            txtNumero.RightToLeft = RightToLeft.Yes;
            txtNumero.Size = new Size(100, 50);
            txtNumero.TabIndex = 1;
            txtNumero.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(628, 43);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Vendedor";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(103, 106);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(249, 23);
            txtVendedor.TabIndex = 5;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(539, 209);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(89, 36);
            btnAbrir.TabIndex = 2;
            btnAbrir.Text = "&Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnInserir);
            groupBox2.Controls.Add(txtQuantidade);
            groupBox2.Controls.Add(txtValorUnit);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtHashCode);
            groupBox2.Controls.Add(txtDescricao);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(616, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Produto";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(527, 42);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(436, 42);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(69, 23);
            txtQuantidade.TabIndex = 7;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(330, 42);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(100, 23);
            txtValorUnit.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(436, 19);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 5;
            label7.Text = "Quantidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 19);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 4;
            label6.Text = "Valor Unitário";
            // 
            // txtHashCode
            // 
            txtHashCode.Location = new Point(15, 42);
            txtHashCode.Name = "txtHashCode";
            txtHashCode.Size = new Size(132, 23);
            txtHashCode.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(153, 42);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(171, 23);
            txtDescricao.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 19);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 1;
            label5.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 19);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 0;
            label4.Text = "Código de Barras";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(616, 150);
            dataGridView1.TabIndex = 7;
            // 
            // btnFinalizarP
            // 
            btnFinalizarP.Location = new Point(646, 465);
            btnFinalizarP.Name = "btnFinalizarP";
            btnFinalizarP.Size = new Size(139, 46);
            btnFinalizarP.TabIndex = 8;
            btnFinalizarP.Text = "&Finalizar Pedido";
            btnFinalizarP.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(685, 369);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(685, 398);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 15F);
            textBox6.Location = new Point(646, 427);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 34);
            textBox6.TabIndex = 11;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 530);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(btnFinalizarP);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(btnAbrir);
            Controls.Add(txtVendedor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(groupBox1);
            Name = "FrmPedido";
            Text = "FrmPedido";
            Load += FrmPedido_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtNumero;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVendedor;
        private Button btnAbrir;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnFinalizarP;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox txtHashCode;
        private TextBox txtDescricao;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private Label label7;
        private Button btnInserir;
    }
}