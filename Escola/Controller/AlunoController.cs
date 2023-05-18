using Escola.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Controller
{
    public class AlunoController
    {
        internal void salvar(Aluno aluno)
        {
            AlunoDAO pDao = new AlunoDAO();
            pDao.create(aluno);
            frmLogin tela = new frmLogin();
            tela.Show();
        }
    }
}
