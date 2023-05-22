using Escola.DAO;
using Escola.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Controller
{
    public class CursoController
    {
        internal void Salvar(object curso)
        {
            CursoDAO cDao = new CursoDAO();
            cDao.create(curso);
            frmCursoAcesso tela = new frmCursoAcesso();
            tela.Show();
        }
    }
}
