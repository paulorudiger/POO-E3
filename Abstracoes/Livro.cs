using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Abstracoes
{
    // Classe que representa um livro na biblioteca
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }

        public Livro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }
}
