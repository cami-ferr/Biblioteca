using Biblioteca;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var configuracao = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string conexao = configuracao.GetConnectionString("BibliotecaConnection");

var options = new DbContextOptionsBuilder<BibliotecaContext>()
    .UseSqlServer(conexao)
    .Options;

using BibliotecaContext contexto = new BibliotecaContext(options);

BibliotecaService biblioteca = new BibliotecaService(contexto);

int opcao = 0;

while (opcao != 10)
{
    Console.WriteLine("\n===== BIBLIOTECA =====");
    Console.WriteLine("1 - Cadastrar livro");
    Console.WriteLine("2 - Listar livros");
    Console.WriteLine("3 - Buscar livro");
    Console.WriteLine("4 - Cadastrar usuário");
    Console.WriteLine("5 - Emprestar livro");
    Console.WriteLine("6 - Devolver livro");
    Console.WriteLine("7 - Listar empréstimos");
    Console.WriteLine("8 - Editar livro");
    Console.WriteLine("9 - Arquivar livro");
    Console.WriteLine("10 - Sair");

    if (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("\nEntrada inválida! Digite um número de 1 a 10.");
        continue;
    }
    if (opcao < 1 || opcao > 10)
    {
        Console.WriteLine("\nEntrada inválida! Digite um número de 1 a 10.");
        continue;
    }

    if (opcao == 1)
    {
        biblioteca.CadastrarLivro();
    }
    else if (opcao == 2)
    {
        biblioteca.ListarLivros();
    }
    else if (opcao == 3)
    {
        biblioteca.BuscarLivro();
    }
    else if (opcao == 4)
    {
        biblioteca.CadastrarUsuario();
    }
    else if (opcao == 5)
    {
        biblioteca.EmprestarLivro();
    }
    else if (opcao == 6)
    {
        biblioteca.DevolverLivro();
    }
    else if (opcao == 7)
    {
        biblioteca.ListarEmprestimos();
    }
    else if (opcao == 8)
    {
        biblioteca.EditarLivro();
    }
    else if (opcao == 9)
    {
        biblioteca.ArquivarLivro();
    }
    else if (opcao == 10)
    {
        Console.WriteLine("\nEncerrando...");
    }
}