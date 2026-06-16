namespace exercicios_get_set.Models.Nivel_Intermediario;

public class Circulo
{
    private double _raio;


    public double Raio
    {
        get => _raio; set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Raio de um círculo deve ser maior ou igual (círculo degenerado) a 0."
                );

            _raio = value;
        }
    }
    private double Diametro { get => 2 * Raio; }
    private double Area { get => Math.PI * Math.Pow(Raio, 2); }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public void VerDiametroEArea()
    {
        if (Raio == 0)
            Console.WriteLine("Círculo degenerado (Raio = 0)");

        Console.WriteLine($"Raio: {Raio:F2} cm - Diâmetro: {Diametro:F2} cm - Área: {Area:F2} cm²");
    }
}
