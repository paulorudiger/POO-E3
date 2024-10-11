using POO_E2.Abstracoes;
using ProjetoBiblioteca.Servicos;
using System;

namespace ProjetoBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializa a biblioteca
            var biblioteca = new Biblioteca();

            // Exemplos de uso
            var professor = new Professor("João Silva", 123);
            var estudante = new Estudante("Ana Souza", 456);
            var livro = new Livro("Aprendizado C#", "Pedro Oliveira");

            // Exibe informações iniciais
            Console.WriteLine($"Professor: {professor.Nome}, Matrícula: {professor.Matricula}");
            Console.WriteLine($"Estudante: {estudante.Nome}, Matrícula: {estudante.Matricula}");
            Console.WriteLine($"Livro: {livro.Titulo}, Autor: {livro.Autor}");
            Console.WriteLine();

            // Reservar um livro
            Console.WriteLine("Realizando a reserva do livro...");
            biblioteca.Reservar(livro, estudante, professor);
            Console.WriteLine();

            // Cancelar uma reserva
            Console.WriteLine("Cancelando a reserva do livro...");
            biblioteca.CancelarReserva(livro, estudante);
            Console.WriteLine();

            // Devolver um livro
            Console.WriteLine("Devolvendo o livro...");
            biblioteca.RegistrarDevolucao(livro, estudante);
            Console.WriteLine();

            // Mensagem final
            Console.WriteLine("Operações realizadas com sucesso!");
        }
    }
}
