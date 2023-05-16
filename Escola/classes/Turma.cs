using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola
{
    public class Turma
    {
        private int id_turma;
        private int id_curso;
        private int id_professor;

        public Professor Professor
        {
            get => default;
            set
            {
            }
        }

        public Curso Curso
        {
            get => default;
            set
            {
            }
        }
    }
}