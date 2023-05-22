using Escola.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Controller
{
    public class NivelController
    {
        public ArrayList listar()
        {
            NivelDAO nivel = new NivelDAO();
            return nivel.all();
        }
    }
}
