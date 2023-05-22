using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.forms
{
    public partial class Informação : Form
    {
        public Informação()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            AlunoAcesso telaAnterior = new AlunoAcesso();
            telaAnterior.Show();
        }
    }
}
