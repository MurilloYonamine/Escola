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
        private int carga_horaria;
        private int id_modalidade;
        private Nivel nivel;
        private Modalidade modalidade;
        public Curso()
        {
            this.nivel = new Nivel();
            this.modalidade = new Modalidade();
        }

        public int Id
        {
            get { return this.id_curso; }
            set { id_curso = value; }
        }
        public string Nome
        {
            get { return this.nome_do_curso; }
            set { this.nome_do_curso = value; }
        }
        public int Carga
        {
            get { return this.carga_horaria; }
            set { this.carga_horaria = value; }
        }

        public Nivel Nivel
        {
            get { return this.nivel; }
            set { this.nivel = value; }
        }
        public Modalidade Modalidade
        {
            get { return this.modalidade; }
            set { this.modalidade = value; }
        }
    }
}