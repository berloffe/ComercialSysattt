﻿using System;
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
    }
}
