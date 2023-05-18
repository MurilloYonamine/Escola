using Escola.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Controller
{
    public class ProfessorController
    {
        internal void salvar(Professor professor)
        {
            ProfessorDAO pDao = new ProfessorDAO();
            pDao.create(professor);
            frmLogin tela = new frmLogin();
            tela.Show();
        }
    }
}
