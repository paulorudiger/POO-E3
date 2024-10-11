using POO_E3.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Abstracoes
{
    // Classe que representa um professor
    public class Professor : Pessoa
    {
        public Professor(string nome, int matricula) : base(nome, matricula) { }
    }
}
