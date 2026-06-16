namespace exercicios_get_set.Models.Nivel_Intermediario;

public class Imovel
{
    private string _endereco;
    private decimal _valor;

    public string Endereco
    {
        get => _endereco; set
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Deve conter um endereço válido"
                );

            _endereco = value;
        }
    }
    public decimal Valor
    {
        get => _valor; set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Valor deve ser maior que 0"
                );

            _valor = value;
        }
    }

    public Imovel(string endereco, decimal valor)
    {
        Endereco = endereco;
        Valor = valor;
    }

    public decimal AplicarDesconto(decimal porcentagem) => Valor - (Valor * porcentagem) / 100;
    public void VerValor(decimal porcentagem)
    {
        Console.WriteLine($"Imóvel - Endereço: {Endereco}, Valor: R${Valor:F2}, Com desconto de {porcentagem}%: R${AplicarDesconto(porcentagem):F2}");
    }
}
