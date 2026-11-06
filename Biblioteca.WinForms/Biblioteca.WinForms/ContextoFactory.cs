using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Biblioteca.WinForms
{
    public static class ContextoFactory
    {
        public static BibliotecaContext Criar()
        {
            string caminho = Path.Combine(AppContext.BaseDirectory, "appsettings.json");

            IConfiguration configuracao = new ConfigurationBuilder()
                .AddJsonFile(caminho)
                .Build();

            string conexao = configuracao.GetConnectionString("BibliotecaConnection");

            var options = new DbContextOptionsBuilder<BibliotecaContext>()
               .UseSqlServer(conexao)
               .Options;

            return new BibliotecaContext(options);
        }
    }
}
