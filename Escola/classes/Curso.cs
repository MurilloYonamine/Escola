using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola
{
    public class Curso
    {
        private int id_curso;
        private String nome_do_curso;
        private DateTime carga_horaria;
        private int id_modalidade;
        private int id_nivel;

        public Modalidade Modalidade
        {
            get => default;
            set
            {
            }
        }

        public Nivel Nivel
        {
            get => default;
            set
            {
            }
        }
    }
}