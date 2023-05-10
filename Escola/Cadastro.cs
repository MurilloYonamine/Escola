﻿using System.Drawing;
using System.Windows.Forms;

namespace Escola
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);
            grpAcesso.ForeColor = Color.White;
            grpDadosPessoais.ForeColor = Color.White;

            this.btnCadastrar.FlatAppearance.BorderSize = 1;
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            frmLogin telaAnterior = new frmLogin();
            telaAnterior.Show();
        }
    }
}
