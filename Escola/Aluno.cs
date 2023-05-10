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
        public int Idade()
        {
            this.idade_aluno = DateTime.Now.Year - this.nascimento_aluno.Year;
            if (DateTime.Now.DayOfYear < this.nascimento_aluno.DayOfYear)
            {
                this.idade_aluno = this.idade_aluno - 1;
            }
            return this.idade_aluno;
        }

        public bool ValidaCPF(string vrCPF)

        {
            string valor = vrCPF.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(
                  valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }

            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }

    }
}