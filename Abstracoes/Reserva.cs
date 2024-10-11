using System;

namespace POO_E2.Abstracoes
{
    // Classe que representa uma reserva de livro
    public class Reserva
    {
        public Livro Livro { get; private set; }
        public Estudante Estudante { get; private set; }
        public Professor Professor { get; private set; }
        public DateTime DataReserva { get; private set; }

        public Reserva(Livro livro, Estudante estudante, Professor professor)
        {
            Livro = livro;
            Estudante = estudante;
            Professor = professor;
            DataReserva = DateTime.Now;
        }

        // Verifica se a reserva foi feita hoje
        public bool FoiReservadoHoje()
        {
            return DataReserva.Date == DateTime.Now.Date;
        }
    }
}
