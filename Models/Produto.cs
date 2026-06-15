namespace exercicios_get_set.Models;

public class Produto
{
    private decimal _preco;

    private string? Nome { get; set; }
    private decimal Preco
    {
        get => _preco; set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(
                nameof(Preco),
                "Preço não pode ser negativo.");

            _preco = value;
        }
    }
    private int Quantidade { get; set; }

    public Produto(string? nome, decimal preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public void ExibirDadosProduto()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R${Preco:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }
}
