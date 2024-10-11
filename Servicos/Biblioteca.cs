using BibliotecaEscola.Servicos;
using POO_E2.Abstracoes;
using POO_E2.Interfaces;
using System;
using System.Collections.Generic;

namespace ProjetoBiblioteca.Servicos
{
    // Classe que gerencia a biblioteca e as reservas de livros
    public class Biblioteca : IGerenciadorReservas
    {
        private List<Livro> livros;
        private List<Estudante> estudantes;
        private List<Reserva> reservas;
        private Log log;

        public Biblioteca()
        {
            livros = new List<Livro>();
            estudantes = new List<Estudante>();
            reservas = new List<Reserva>();
            log = new Log();

            // Dados predefinidos
            var professor = new Professor("Pedro", 123);
            var livro = new Livro("Programação C#", "João Oliveira");
            livros.Add(livro);

            var estudante = new Estudante("Paulo", 456);
            estudantes.Add(estudante);

            var reserva = new Reserva(livro, estudante, professor);
            reservas.Add(reserva);
        }

        // Método para reservar um livro
        public void Reservar(Livro livro, Estudante estudante, Professor professor)
        {
            var reserva = new Reserva(livro, estudante, professor);
            reservas.Add(reserva);
            Console.WriteLine($"Livro '{livro.Titulo}' reservado para {estudante.Nome} com a ajuda do professor {professor.Nome}.");
            log.Gravar($"Reserva: Livro '{livro.Titulo}' reservado por {estudante.Nome} com o professor {professor.Nome}.");
        }

        // Método para cancelar uma reserva
        public void CancelarReserva(Livro livro, Estudante estudante)
        {
            var reserva = reservas.Find(r => r.Livro == livro && r.Estudante == estudante);
            if (reserva != null)
            {
                reservas.Remove(reserva);
                Console.WriteLine($"Reserva do livro '{livro.Titulo}' por {estudante.Nome} cancelada.");
                log.Gravar($"Reserva cancelada: Livro '{livro.Titulo}' por {estudante.Nome}.");
            }
            else
            {
                Console.WriteLine($"Reserva do livro '{livro.Titulo}' por {estudante.Nome} não encontrada.");
                log.Gravar($"Tentativa de cancelamento falhou: Reserva não encontrada para o livro '{livro.Titulo}' e o estudante {estudante.Nome}.");
            }
        }

        // Método para registrar devolução de livro
        public void RegistrarDevolucao(Livro livro, Estudante estudante)
        {
            Console.WriteLine($"Livro '{livro.Titulo}' devolvido por {estudante.Nome}.");
            log.Gravar($"Devolução: Livro '{livro.Titulo}' devolvido por {estudante.Nome}.");
        }
    }
}
