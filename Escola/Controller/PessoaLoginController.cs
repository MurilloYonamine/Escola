using Escola.classes;
using Escola.DAO;
using Escola.forms;
using Escola.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Controller
{
    public class PessoaLoginController
    {
        public Pessoa Logar(Pessoa pessoa)
        {
            PessoaLoginDAO pessoaDAO = new PessoaLoginDAO();

            pessoa = (Pessoa) pessoaDAO.read(pessoa);

            if(pessoa != null)
            {
                if(pessoa.Nome.Equals("aluno"))
                {
                    AlunoAcesso telaAluno = new AlunoAcesso();
                    telaAluno.Show();
                }
                else if(pessoa.Nome.Equals("professor"))
                {
                    frmProfessorAcesso telaProfessor = new frmProfessorAcesso();
                    telaProfessor.Show();
                }
            }
            return pessoa;
        }
        public void Deslogar()
        {

        }

    }
}
