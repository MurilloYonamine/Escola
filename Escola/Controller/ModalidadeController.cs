using Escola.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Controller
{
    public class ModalidadeController
    {
        public ArrayList listar()
        {
            ModalidadeDAO modalidade = new ModalidadeDAO();
            return modalidade.all();
        }
    }
}
