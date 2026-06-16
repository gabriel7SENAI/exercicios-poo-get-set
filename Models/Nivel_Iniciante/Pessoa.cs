namespace exercicios_get_set.Models.Nivel_Iniciante;

public class Pessoa
{
    private int _idade;

    public int Idade
    {
        get => _idade; set
        {
            _idade = value;

            if (value >= 18)
                Console.WriteLine("Maior de idade");
            else
                Console.WriteLine("Menor de idade");
        }
    }

    public Pessoa(int idade)
    {
        Idade = idade;
    }
}
