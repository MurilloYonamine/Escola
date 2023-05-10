using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Escola
{
    public class Aluno
    {
        private string email_aluno;
        private string senha_aluno;
        private string nome_aluno;
        private int id_aluno;
        private DateTime nascimento_aluno;
        private int idade_aluno;
        private string cpf_aluno;
        private string nome_social;
        private string genero;

        public Aluno(string email_aluno, string senha_aluno, string nome_aluno, DateTime nascimento_aluno, string cpf_aluno, string nome_social, string genero)
        {
            this.email_aluno = email_aluno;
            this.senha_aluno = senha_aluno;
            this.nome_aluno = nome_aluno;
            this.nascimento_aluno = nascimento_aluno;
            this.cpf_aluno = cpf_aluno;
            this.nome_social = nome_social;
            this.genero = genero;
        }
        public string Email_aluno
        {
            get { return this.email_aluno; }
            set { this.email_aluno = value; }
        }
        public string Senha_aluno
        {
            get { return this.senha_aluno; }
            set { this.senha_aluno = value; }
        }
        public string Nome_aluno
        {
            get { return this.nome_aluno; }
            set { this.nome_aluno = value; }
        }
        public DateTime Nascimento_aluno
        {
            get { return this.nascimento_aluno; }
            set { this.nascimento_aluno = value; }
        }
        public string Cpf_aluno
        {
            get { return this.cpf_aluno; }
            set { cpf_aluno = value; }
        }
        public string Nome_social
        {
            get { return this.nome_social; }
            set { nome_social = value; }
        }
        public string Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }

        public bool Email_verificacao()
        {
            try
            {
                MailAddress email_verify = new MailAddress(this.email_aluno);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}