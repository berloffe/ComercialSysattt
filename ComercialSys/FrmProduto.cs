using ComClassSys;
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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Produto produto = new Produto(

                mskCodigo.Text

              , txtDescricao.Text
              , Convert.ToDouble(mskValor.Text)
              , cmbUnidedeVendas.Text
              , Convert.ToInt32(txtCategoria.Text)
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)
                );

            produto.Inserir();
            if (produto.Id > 0)
            {
                MessageBox.Show($"Produto {produto.GetHashCode()} cadastrado com sucesso");
            }


        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            /*var lista = Produto.
            dgvProdutos.Rows.Clear();
            int count = 0;
            foreach (var  in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[count].Cells[0].Value = Produto.
            }*/
        }

        private void btnObterPorID_Click(object sender, EventArgs e)
        {
            if (btnObterPorID.Text == "&Obter por ID")
            {
                mskCodigo.Clear();
                txtDescricao.Clear();
                mskValor.Clear();
                txtCategoria.Clear();
                txtEstoqueMinimo.Clear();
                txtClasseDesconto.Clear();
                txtId.ReadOnly = false;
                txtId.Focus();
                btnObterPorID.Text = "&Obter por ID";
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Produto produto = Produto.ObterPorID(int.Parse(txtId.Text));
                    produto.CodBarras = mskCodigo.Text;
                    produto.Descricao = txtDescricao.Text;
                    produto.ValoUnit = Convert.ToDouble(mskValor.Text);
                    produto.UnidadeVenda = cmbUnidedeVendas.Text;
                    produto.CategoriaId = int.Parse(txtCategoria.Text);
                    produto.EstoqueMinimo = Convert.ToDouble(txtEstoqueMinimo.Text);
                    produto.ClasseDesconto = Convert.ToDouble(txtClasseDesconto.Text);

                    txtId.ReadOnly = true;
                    btnObterPorID.Text = "&Obter por ID";
                    btnEditar.Enabled = true;

                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            mskCodigo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskValor.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Produto produto = new Produto(mskCodigo.Text

              , txtDescricao.Text
              , Convert.ToDouble(mskValor.Text)
              , cmbUnidedeVendas.Text
              , Convert.ToInt32(txtCategoria.Text)
              , Convert.ToDouble(txtEstoqueMinimo.Text)
              , Convert.ToDouble(txtClasseDesconto.Text)
              );

            if (produto.Editar(produto.Id))
            {
                MessageBox.Show($"o Produto {produto.Descricao} foi alterado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Falha ao alterar o produto \"{produto.Descricao}\" !");
            }

        }

        private void cmbUnidedeVendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
} 
