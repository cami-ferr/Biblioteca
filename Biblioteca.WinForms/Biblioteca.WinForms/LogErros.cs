using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca.WinForms
{
    public static class LogErros
    {
        public static void Registrar(Exception erro)
        {
            string pasta = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Logs"
            );

            Directory.CreateDirectory(pasta);

            string arquivo = Path.Combine(pasta, "logs.txt");

            string mensagem =
                $"Data: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n" +
                $"Erro: {erro}\n" +
                "----------------------------------------\n";

            File.AppendAllText(arquivo, mensagem);
        }
    }
}
