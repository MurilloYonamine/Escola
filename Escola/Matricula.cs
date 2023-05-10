using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Escola
{
    public class Matricula
    {
        private int id_matricula;
        private int id_turma;
        private int id_aluno;

        public Turma Turma
        {
            get => default;
            set
            {
            }
        }

        public Aluno Aluno
        {
            get => default;
            set
            {
            }
        }
    }
}