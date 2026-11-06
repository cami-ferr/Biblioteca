using Microsoft.EntityFrameworkCore;

namespace Biblioteca;

public class BibliotecaContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }
}