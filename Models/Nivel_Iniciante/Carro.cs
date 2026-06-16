namespace exercicios_get_set.Models.Nivel_Iniciante;

public class Carro
{
    private int _ano;

    public string Marca { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public int Ano
    {
        get => _ano; set
        {
            if (value < 1886)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Não são aceitos carros fabricados antes de 1886."
                );
            _ano = value;
        }
    }

    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
}