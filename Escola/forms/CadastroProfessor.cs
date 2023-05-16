using Escola.classes;
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
            Professor professor = new Professor();
            professor.Email = txtEmail.Text;
            string confirmarEmail = txtConfirmarEmail.Text;
            professor.Senha = txtSenha.Text;
            string ConfirmarSenha = txtConfirmarSenha.Text;
            professor.Nome = txtNome.Text;
            professor.Nome_social = txtNomeSocial.Text;
            professor.Cpf = txtCpf.Text;
            professor.Nascimento = dtpNascimento.Value;
            professor.Genero = "";
            professor.Formacao = txtFormacao.Text;
            professor.Titulacao = "";

            //Titulação
            if (rdoBacharelado.Checked)
            {
                professor.Titulacao = "Bacharelado";
            }

            if (rdoLicenciatura.Checked)
            {
                professor.Titulacao = "Licenciatura";
            }

            if (rdoTecnologo.Checked)
            {
                professor.Titulacao = "Tecnólogo";
            }

            if (rdoEspecializacao.Checked)
            {
                professor.Titulacao = "Especialização";
            }

            if (rdoMba.Checked)
            {
                professor.Titulacao = "MBA";
            }

            if (rdoMestrado.Checked)
            {
                professor.Titulacao = "Mestrado";
            }

            if (rdoDoutorado.Checked)
            {
                professor.Titulacao = "Doutorado";
            }

            if (rdoPosDoutorado.Checked)
            {
                professor.Titulacao = "Pós doutorado";
            }

            //Gênero
            if (rdoMasculino.Checked)
            {
                professor.Genero = "Masculino";
            }
            else if (rdoFeminino.Checked)
            {
                professor.Genero = "Feminino";
            }
            else if (rdoNaoBinario.Checked)
            {
                professor.Genero = txtNaoBinario.Text;
            }


            //Validação CPF
            professor.ValidaCPF(professor.Cpf);

            //Verificação Email
            if (professor.Email_verificacao() == true && confirmarEmail == professor.Email && ConfirmarSenha == professor.Senha)
            {
                MessageBox.Show("Cadastrado com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

    }
}
