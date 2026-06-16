namespace exercicios_get_set.Models.Nivel_Intermediario;

public class Paciente
{
    private double _peso;

    public string Nome { get; set; }
    public double Peso
    {
        get => _peso; set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(Peso),
                    "Peso deve ser maior que 0"
                );

            _peso = value;
        }
    }

    public Paciente(string nome, double peso)
    {
        Nome = nome;
        Peso = peso;
    }

    public void VerDadosPaciente()
    {
        Console.WriteLine($"Paciente: {Nome} - Peso: {Peso:F2}Kg");
    }
}
