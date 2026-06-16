namespace exercicios_get_set.Models.Nivel_Intermediario;

public class Temperatura
{
    public double Celsius { get; set; }
    public double Fahrenheit { get => (Celsius * 1.8) + 32; }

    public Temperatura(double celsius)
    {
        Celsius = celsius;
    }

    public void VerTemperatura()
    {
        Console.WriteLine($"Temperatura em Celsius: {Celsius:F2}°C - Fahrenheit: {Fahrenheit:F2}°C");
    }
}
