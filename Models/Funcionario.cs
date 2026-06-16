namespace exercicios_get_set.Models;

public class Funcionario
{
    private decimal _salario;


    public string Nome { get; set; }
    private decimal Salario
    {
        get => _salario; set
        {
            if (value <= 1621.00m)
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Salário deve ser maior que R$1.621,00."
                );

            _salario = value;
        }
    }

    public Funcionario(string nome, decimal salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public void VerSalario()
    {
        Console.WriteLine($"Salário ajustado para R${Salario:F2}");
    }
}
