using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class BibliotecaService
    {
        private readonly BibliotecaContext contexto;

        public BibliotecaService(BibliotecaContext contexto)
        {
            this.contexto = contexto;
        }

        public void CadastrarLivro()
        {
            string titulo = Entrada.LerTexto("\nDigite o título: ");

            string autor = Entrada.LerTexto("Digite o autor: ");

            string genero = Entrada.LerTexto("Digite o gênero: ");

            int ano = Entrada.LerInteiro("Digite o ano: ");

            Livro livro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Genero = genero,
                Ano = ano,
                Disponivel = true,
                Ativo = true
            };

            contexto.Livros.Add(livro);
            contexto.SaveChanges();

            Console.WriteLine("\nLivro cadastrado com sucesso!");
        }

        public void ListarLivros()
        {
            var livros = contexto.Livros
                .Where(livro => livro.Ativo)
                .ToList();

            Console.WriteLine("\n===== LIVROS =====");

            foreach (var livro in livros)
            {
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
                Console.WriteLine($"Gênero: {livro.Genero}");
                Console.WriteLine($"Ano: {livro.Ano}");
                Console.WriteLine($"Disponível: {livro.Disponivel}");
                Console.WriteLine("----------------------");
            }
        }

        public void BuscarLivro()
        {
            string titulo = Entrada.LerTexto("\nDigite o título do livro: ");

            var encontrados = contexto.Livros
                .Where(livro => livro.Ativo && livro.Titulo.ToLower().Contains(titulo.ToLower()))
                .ToList();

            if (encontrados.Count == 0){
                Console.WriteLine("\nLivro não encontrado.");
            }

            foreach (var livro in encontrados)
            {
                    Console.WriteLine("\n===== LIVRO ENCONTRADO =====");
                    Console.WriteLine($"Título: {livro.Titulo}");
                    Console.WriteLine($"Autor: {livro.Autor}");
                    Console.WriteLine($"Gênero: {livro.Genero}");
                    Console.WriteLine($"Ano: {livro.Ano}");
                    Console.WriteLine($"Disponível: {livro.Disponivel}");

                  
            }

        }

        public void EditarLivro()
        {
            string busca = Entrada.LerTexto("\nDigite o título do livro que deseja editar: ");

            Livro? livroEncontrado = contexto.Livros
                .FirstOrDefault(livro => livro.Ativo && livro.Titulo.ToLower() == busca.ToLower());

            if (livroEncontrado == null)
            {
                Console.WriteLine("\nLivro não encontrado.");
                return;
            }

            Console.WriteLine("\nDeixe um campo vazio para manter o valor atual.");

            Console.Write($"Novo título ({livroEncontrado.Titulo}): ");
            string? novoTitulo = Console.ReadLine();

            Console.Write($"Novo autor ({livroEncontrado.Autor}): ");
            string? novoAutor = Console.ReadLine();

            Console.Write($"Novo gênero ({livroEncontrado.Genero}): ");
            string? novoGenero = Console.ReadLine();

            Console.Write($"Novo ano ({livroEncontrado.Ano}): ");
            string? novoAno = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novoTitulo))
            {
                livroEncontrado.Titulo = novoTitulo.Trim();
            }

            if (!string.IsNullOrWhiteSpace(novoAutor))
            {
                livroEncontrado.Autor = novoAutor.Trim();
            }

            if (!string.IsNullOrWhiteSpace(novoGenero))
            {
                livroEncontrado.Genero = novoGenero.Trim();
            }

            if (!string.IsNullOrWhiteSpace(novoAno))
            {
                if (int.TryParse(novoAno, out int ano))
                {
                    livroEncontrado.Ano = ano;
                }
                else
                {
                    Console.WriteLine("\nAno inválido. O ano anterior será mantido.");
                }
            }

            contexto.SaveChanges();

            Console.WriteLine("\nLivro atualizado com sucesso!");
        }

        public void ArquivarLivro()
        {
            string busca = Entrada.LerTexto("\nDigite o título do livro que deseja arquivar: ");

            Livro? livroEncontrado = contexto.Livros
                .FirstOrDefault(livro => livro.Titulo.ToLower() == busca.ToLower() && livro.Ativo);

            if (livroEncontrado == null)
            {
                Console.WriteLine("\nLivro não encontrado.");
                return;
            }

            bool possuiEmprestimoAtivo = contexto.Emprestimos
                .Any(e => e.LivroId == livroEncontrado.Id
                       && e.DataDevolucao == null);

            if (possuiEmprestimoAtivo)
            {
                Console.WriteLine("\nNão é possível arquivar este livro, pois ele está emprestado.");
                return;
            }

            livroEncontrado.Ativo = false;
            contexto.SaveChanges();

            Console.WriteLine("\nLivro arquivado com sucesso!");
        }

        public void CadastrarUsuario()
        {
            string nome = Entrada.LerTexto("\nDigite o nome: ");

            string email = Entrada.LerTexto("Digite o e-mail: ");

            Usuario usuario = new Usuario
            {
                Nome = nome,
                Email = email
            };

            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();

            Console.WriteLine("\nUsuário cadastrado com sucesso!");
        }
       
        public void EmprestarLivro()
        {
            string buscaLivro = Entrada.LerTexto("\nDigite o título do livro: ");

            Livro? livroEncontrado = contexto.Livros
                .FirstOrDefault(livro => livro.Ativo && livro.Titulo.ToLower() == buscaLivro.ToLower());
   

            if (livroEncontrado == null)
            {
                Console.WriteLine("\nLivro não encontrado.");
                return;
            }

            bool possuiEmprestimoAtivo = contexto.Emprestimos
     .Any(e => e.LivroId == livroEncontrado.Id
            && e.DataDevolucao == null);

            if (!livroEncontrado.Disponivel || possuiEmprestimoAtivo)
            {
                Console.WriteLine("\nEsse livro já está emprestado.");
                return;
            }

            string buscaUsuario = Entrada.LerTexto("\nDigite o nome do usuário: ");


            Usuario? usuarioEncontrado = contexto.Usuarios
                .FirstOrDefault(usuario => usuario.Nome.ToLower() == buscaUsuario.ToLower());


            if (usuarioEncontrado == null)
            {
                Console.WriteLine("\nUsuário não encontrado.");
                return;
            }

            Emprestimo emprestimo = new Emprestimo
            {
                LivroId = livroEncontrado.Id,
                Livro = livroEncontrado,
                Usuario = usuarioEncontrado,
                UsuarioId = usuarioEncontrado.Id,
                DataEmprestimo = DateTime.Now
            };

            contexto.Emprestimos.Add(emprestimo);
            livroEncontrado.Disponivel = false;
            contexto.SaveChanges();

            Console.WriteLine("\nEmpréstimo realizado com sucesso!");
        }

        public void DevolverLivro()
        {

            string busca = Entrada.LerTexto("\n Digite o título do livro que deseja devolver: ");

            var livroEncontrado = contexto.Livros
                .FirstOrDefault(livro => livro.Titulo.ToLower() == busca.ToLower());

            if (livroEncontrado == null)
            {
                Console.WriteLine("\nLivro não encontrado.");
                return;
            }

            Emprestimo? emprestimoAtivo = contexto.Emprestimos
                .FirstOrDefault(e => e.LivroId == livroEncontrado.Id
                && e.DataDevolucao == null);

            if (emprestimoAtivo == null)
            {
                Console.WriteLine("\nNão foi encontrado um empréstimo ativo desse livro.");
                return;
            }
            
                livroEncontrado.Disponivel = true;
                emprestimoAtivo.DataDevolucao = DateTime.Now;
                contexto.SaveChanges();
                Console.WriteLine("\nLivro devolvido com sucesso!");
            
        }

        public void ListarEmprestimos()
        {
            Console.WriteLine("\n===== EMPRÉSTIMOS =====");

            var emprestimos = contexto.Emprestimos
                .Include(emprestimo => emprestimo.Livro)
                .Include(emprestimo => emprestimo.Usuario)
                .ToList();

            if (emprestimos.Count == 0)
            {
                Console.WriteLine("Não existem empréstimos registrados.");
                return;
            }

            foreach (Emprestimo emprestimo in emprestimos)
            {
                Console.WriteLine($"Livro: {emprestimo.Livro.Titulo}");
                Console.WriteLine($"Usuário: {emprestimo.Usuario.Nome}");
                Console.WriteLine($"Data de empréstimo: {emprestimo.DataEmprestimo}");
                Console.WriteLine(emprestimo.DataDevolucao == null
                   ? "Status: Em andamento"
                   : $"Devolvido em: {emprestimo.DataDevolucao}");
                Console.WriteLine("----------------------");
            }
        }
    }
}
