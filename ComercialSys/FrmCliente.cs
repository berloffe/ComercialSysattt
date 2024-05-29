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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }
        private void CarregaGrid(int clienteId)
        {
            var listaEnderecos = Endereco.ObterListaPorCliente(clienteId);
            int count = 0;
            // Preenche o DataGridView com todos os endereços
            dgvEnderecos.Rows.Clear();
            foreach (var endereco in listaEnderecos)
            {
                int rowIndex = dgvEnderecos.Rows.Add();
                dgvEnderecos.Rows[count].Cells[0].Value = endereco.Cep;
                dgvEnderecos.Rows[count].Cells[1].Value = endereco.Logradouro;
                dgvEnderecos.Rows[count].Cells[2].Value = endereco.Numero;
                dgvEnderecos.Rows[count].Cells[3].Value = endereco.Complemento;
                dgvEnderecos.Rows[count].Cells[4].Value = endereco.Bairro;
                dgvEnderecos.Rows[count].Cells[5].Value = endereco.Cidade;
                dgvEnderecos.Rows[count].Cells[6].Value = endereco.Uf;
                dgvEnderecos.Rows[count].Cells[7].Value = endereco.TipoEndereco;
                count++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TipoEnd = cmbTipoEndereco.SelectedItem.ToString();
            TipoEnd = TipoEnd.Substring(0, 3);
            mxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Endereco endereco = new(
                 int.Parse(txtClienteId.Text),
                 mxtCEP.Text,
                 txtLogradouro.Text,
                 txtNumero.Text,
                 txtComplemento.Text,
                 txtBairro.Text,
                 txtCidade.Text,
                 txtUf.Text,
                 TipoEnd

                 );

            endereco.Inserir();

            CarregaGrid(int.Parse(txtClienteId.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mstTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Cliente cliente = new Cliente(txtNome.Text,
                  mxtCpf.Text
                , mstTelefone.Text
                , txtEmail.Text
                , dtpDataNasc.Value
                );
            cliente.Inserir();
            if (cliente.Id > 0)
            {
                MessageBox.Show($"Cliente {cliente.GetHashCode()} cadastro com sucesso");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {

        }

        private void mxtCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void mxtCEP_Leave(object sender, EventArgs e)
        {
            mxtCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (mxtCEP.Text.Length == 8)
            {
                WebCEP webCEP = new(mxtCEP.Text);
                txtLogradouro.Text = webCEP.TipoLagradouro + " " + webCEP.Lagradouro;
                txtBairros.Text = webCEP.Bairro;
                txtCidade.Text = webCEP.Cidade;
                txtUf.Text = webCEP.UF;
                txtNumero.Focus();

            }
        }
    }
}
