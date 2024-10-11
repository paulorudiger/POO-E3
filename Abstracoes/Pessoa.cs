using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E3.Abstracoes
{
    // Classe abstrata que representa uma pessoa (professor ou estudante)
    public abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public int Matricula { get; protected set; }

        protected Pessoa(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}
