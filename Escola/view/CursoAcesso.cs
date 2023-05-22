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
    public partial class frmCursoAcesso : Form
    {
        public frmCursoAcesso()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void btnAdicionarCurso_Click(object sender, EventArgs e)
        {
            frmCadastroCurso tela = new frmCadastroCurso();
            tela.Show();
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            frmCoordenador telaAnterior = new frmCoordenador();
            telaAnterior.Show();
        }
    }
}
