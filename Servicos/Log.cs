using System;
using System.IO;

namespace BibliotecaEscola.Servicos
{
    // Classe responsável pelo registro de logs em arquivo
    public class Log
    {
        private const string caminhoLog = "E:\\Facul\\POO-E3\\POO-E3\\log.txt"; // Caminho do log

        // Grava uma mensagem de log no arquivo
        public void Gravar(string mensagem)
        {
            using (StreamWriter escritor = new StreamWriter(caminhoLog, true))
            {
                escritor.WriteLine($"{DateTime.Now}: {mensagem}");
            }
        }
    }
}
