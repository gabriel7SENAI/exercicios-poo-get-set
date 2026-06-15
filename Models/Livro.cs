namespace exercicios_get_set.Models;

public class Livro
{
    private int _numeroPaginas;

    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public int NumeroPaginas
    {
        get => _numeroPaginas; set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(NumeroPaginas),
                    "Número de páginas deve ser maior que 0");

            _numeroPaginas = value;
        }
    }

    public Livro(string? titulo, string? autor, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    public void ExibirDadosLivro()
    {
        Console.WriteLine($"Título: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
    }
}
