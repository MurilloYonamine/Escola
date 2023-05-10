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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Customização do formulário
            this.BackColor = Color.FromArgb(43, 43, 43);

            this.btnLogin.FlatStyle = FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 1;

            this.btnCadastro.FlatStyle = FlatStyle.Flat;
            this.btnCadastro.FlatAppearance.BorderSize = 1;     
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            // Chamar o formulário cadastro
            frmCadastro tela = new frmCadastro();
            tela.Show();
            this.Hide();
        }

        private void Encerrar(object sender, FormClosedEventArgs e)
        {
            //Fechar o formulário login
            System.Environment.Exit(0);
        }

        private void chkConectado_CheckedChanged(object sender, EventArgs e)
        {
            if(chkConectado.Checked == true)
            {
                chkConectado.Text = "Não vou lembrar KK";
            }
            else
            {
                chkConectado.Text = "Lembre de mim";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;

            if(usuario == "coordenador" && senha == "123")
            {
                MessageBox.Show("Seja bem vindo coordenador!", "Bem vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCoordenador tela = new frmCoordenador();
                tela.Show();
                this.Hide();
            }
            if(usuario == "" && senha == "")
            {
                MessageBox.Show("Por favor digite um usuário ou senha válido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
