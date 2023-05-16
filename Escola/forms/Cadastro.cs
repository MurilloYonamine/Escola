using Escola.classes;
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
            Aluno aluno = new Aluno();
            aluno.Email = txtEmail.Text;
            string confirmarEmail = txtConfirmarEmail.Text;
            aluno.Senha = txtSenha.Text;
            string ConfirmarSenha = txtConfirmarSenha.Text;
            aluno.Nome = txtNome.Text;
            aluno.Nome_social = txtNomeSocial.Text;
            aluno.Cpf = txtCpf.Text;
            aluno.Nascimento = dtpNascimento.Value;
            aluno.Genero = "";

            //Alimentar a variável gênero
            if (rdoMasculino.Checked)
            {
                aluno.Genero = "Masculino";
            }
            else if (rdoFeminino.Checked)
            {
                aluno.Genero = "Feminino";
            }
            else if (rdoNaoBinario.Checked)
            {
                aluno.Genero = txtNaoBinario.Text;
            }

            //Instânciamento da classe aluno
            aluno.ValidaCPF(aluno.Cpf);

            if (aluno.Email_verificacao() == true && confirmarEmail == aluno.Email && ConfirmarSenha == aluno.Senha && chkPoliticas.Checked == true)
            {
                MessageBox.Show("Cadastrado com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERRO!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
