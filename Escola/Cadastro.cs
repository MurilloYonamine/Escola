using System;
using System.Drawing;
using System.Net.Mail;
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

        private void rdoNaoBinario_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdoNaoBinario.Checked)
            {
                txtNaoBinario.Visible = true;
            }
            else
            {
                txtNaoBinario.Visible = false;
                txtNaoBinario.Text = "";
            }
        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {

            string email = txtEmail.Text;
            string confirmarEmail = txtConfirmarEmail.Text;
            string senha = txtSenha.Text;
            string ConfirmarSenha = txtConfirmarSenha.Text;
            string nome = txtNome.Text;
            string nome_social = txtNomeSocial.Text;
            string cpf = txtCpf.Text;
            DateTime nascimento = dtpNascimento.Value;
            string genero = "";

            //Alimentar a variável gênero
            if (rdoMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rdoFeminino.Checked)
            {
                genero = "Feminino";
            }
            else if (rdoNaoBinario.Checked)
            {
                genero = txtNaoBinario.Text;
            }

            //Instânciamento da classe aluno
            Aluno aluno = new Aluno(email, senha, nome, nascimento, cpf, nome_social, genero);
            aluno.ValidaCPF(cpf);
            
            if(aluno.Email_verificacao() == true && confirmarEmail == email && ConfirmarSenha == senha)
            {
                MessageBox.Show("Cadastrado com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
