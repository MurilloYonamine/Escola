using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class frmCoordenador : Form
    {
        public frmCoordenador()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            frmLogin telaAnterior = new frmLogin();
            telaAnterior.Show();
        }

        private void btnAdicionarProfessor_Click(object sender, EventArgs e)
        {
            frmCadastroProfessor tela = new frmCadastroProfessor();
            tela.Show();
            this.Hide();
        }
    }
}
