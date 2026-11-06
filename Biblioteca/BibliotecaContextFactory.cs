
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Biblioteca;

public class BibliotecaContextFactory : IDesignTimeDbContextFactory<BibliotecaContext>
{
    public BibliotecaContext CreateDbContext(string[] args)
    {
        var configuracao = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string conexao = configuracao.GetConnectionString("BibliotecaConnection")
            ?? throw new InvalidOperationException("String de conexão não encontrada.");

        var options = new DbContextOptionsBuilder<BibliotecaContext>()
            .UseSqlServer(conexao)
            .Options;

        return new BibliotecaContext(options);
    }
}