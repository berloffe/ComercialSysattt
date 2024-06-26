﻿using ComClassSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercialSys
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            txtVendedor.Text = Program.Usuario.Id + " - " + Program.Usuario.Nome;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Clear();
            if (textBox2.Text.Length > 0)
            {
                var cliente = Cliente.ObterPorId(int.Parse(textBox2.Text));
                if (cliente.Id > 0)
                {
                    textBox3.Text = cliente.Nome;
                }
            }
        }

        private void btnAbrirNovo_Click(object sender, EventArgs e)
        {
            Pedido pedido = new();
            pedido.Cliente = Cliente.ObterPorId(int.Parse(textBox2.Text));
            pedido.Usuario = Program.Usuario;
            pedido.Status = "A";
            pedido.Desconto = 0;
            pedido.Inserir();
            txtNumeroPedido.Text = pedido.Id.ToString();
            gbxProduto.Enabled = true;
            btnAbrirNovo.Enabled = false;
        }

        private void txtHashCode_TextChanged(object sender, EventArgs e)
        {
            if (txtHashCode.Text.Length > 4)
            {
                var produto = Produto.ObterPorID(int.Parse(txtHashCode.Text));
                if (produto.Id > 0)
                    txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValoUnit.ToString();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ItemPedido itempedido = new(int.Parse(txtNumeroPedido.Text)
                , Produto.ObterPorID(int.Parse(txtHashCode.Text))
                , double.Parse(txtValorUnit.Text)
                , double.Parse(txtQuantidade.Text)
                , 0
                );
            itempedido.Inserir();
        }
    }
}
