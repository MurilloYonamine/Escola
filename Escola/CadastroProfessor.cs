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
    public partial class frmCadastroProfessor : Form
    {
        public frmCadastroProfessor()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);
            grpAcesso.ForeColor = Color.White;
            grpDadosPessoais.ForeColor = Color.White;
            grpTitulacao.ForeColor = Color.White;
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            frmCoordenador telaAnterior = new frmCoordenador();
            telaAnterior.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
