using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca;

public static class Entrada
{
    public static int LerInteiro(string mensagem)
    {
        int valor;

        while (true)
        {
            Console.Write(mensagem);

            if (int.TryParse(Console.ReadLine(), out valor))
            {
                return valor;
            }

            Console.WriteLine("Digite um número válido.");
        }
    }

    public static string LerTexto(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);

            string texto = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }

            Console.WriteLine("Esse campo não pode ficar vazio.");
        }
    }
}