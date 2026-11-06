using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca;

public class Livro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }
    public int Ano { get; set; }
    public bool Disponivel { get; set; }
    public bool Ativo { get; set; } = true;
}
