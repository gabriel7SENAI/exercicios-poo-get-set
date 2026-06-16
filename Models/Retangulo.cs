namespace exercicios_get_set.Models;

public class Retangulo
{
    private double _base;
    private double _altura;

    public double Base
    {
        get => _base; set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Valor deve ser maior que 0"
                );
            _base = value;
        }
    }
    public double Altura
    {
        get => _altura; set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Valor deve ser maior que 0"
                );
            _altura = value;
        }
    }
    public double CalcularArea { get => Base * Altura; }

    public Retangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }
}
