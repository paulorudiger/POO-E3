using POO_E2.Abstracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_E2.Interfaces
{
    // Interface para definir os métodos de gerenciamento de reservas
    public interface IGerenciadorReservas
    {
        void Reservar(Livro livro, Estudante estudante, Professor professor);
        void CancelarReserva(Livro livro, Estudante estudante);
        void RegistrarDevolucao(Livro livro, Estudante estudante);
    }
}
