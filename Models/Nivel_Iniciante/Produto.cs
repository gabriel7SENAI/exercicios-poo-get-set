namespace exercicios_get_set.Models.Nivel_Iniciante;

public class Produto
{
    private decimal _preco;
    private int _quantidade;

    private string Nome { get; set; } = string.Empty;
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
    private int Quantidade
    {
        get => _quantidade; set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(
                nameof(Quantidade),
                "Quantidade não pode ser negativa.");
        }
    }

    public Produto(string nome, decimal preco, int quantidade)
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
