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
    public partial class AlunoAcesso : Form
    {
        public AlunoAcesso()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            // Chamar o formulário de informações do aluno
            frmCadastro tela = new frmCadastro();
            tela.Show();
            this.Hide();
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            //Fechar o formulário do aluno
            System.Environment.Exit(0);
        }
    }
}
