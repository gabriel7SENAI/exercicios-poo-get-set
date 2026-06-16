namespace exercicios_get_set.Models.Nivel_Iniciante;

public class ContaBancaria
{
    public int NumeroConta { get; }
    private decimal Saldo { get; set; }

    public ContaBancaria(int numeroConta)
    {
        NumeroConta = numeroConta;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException(
            nameof(valor),
            "Não é possível depositar valores menores ou igual a 0"
            );

        Saldo += valor;
    }
    public void Sacar(decimal valor)
    {
        if (valor <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(valor),
                "O valor do saque deve ser maior que 0."
            );

        if (valor > Saldo)
            throw new InvalidOperationException("Saldo insuficiente.");


        Saldo -= valor;
    }

    public void ExibirSaldo() => Console.WriteLine($"Saldo: R${Saldo:F2}");
}
