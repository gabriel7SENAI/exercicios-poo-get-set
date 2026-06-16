namespace exercicios_get_set.Models.Nivel_Intermediario;

public class Data
{
    private int _dia;
    private int _mes;


    public int Dia
    {
        get => _dia; set
        {
            if (value < 1 || value > 31)
                throw new ArgumentOutOfRangeException(
                    nameof(Dia),
                    "Dia deve ser entre 1 e 31"
                );

            _dia = value;
        }
    }
    public int Mes
    {
        get => _mes; set
        {
            if (value < 1 || value > 12)
                throw new ArgumentOutOfRangeException(
                    nameof(Mes),
                    "Mês deve ser entre 1 e 12"
                );

            _mes = value;
        }
    }
    public int Ano { get; set; }

    public Data(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;

        ValidarData();
    }

    public bool EhBissexto()
    {
        return (Ano % 4 == 0 && Ano % 100 != 0) || (Ano % 400 == 0);
    }

    public void ValidarData()
    {
        if (Mes == 4 || Mes == 6 || Mes == 9 || Mes == 11)
        {
            if (Dia > 30)
                throw new ArgumentOutOfRangeException(
                    nameof(Dia),
                    $"O mês {Mes} possui no máximo 30 dias");
        }

        if (Mes == 2)
        {
            if (EhBissexto() && Dia > 29)
                throw new ArgumentOutOfRangeException(
                nameof(Dia),
                $"O mês {Mes} em anos bissextos possui no máximo 29 dias");

            if (!EhBissexto() && Dia > 28)
                throw new ArgumentOutOfRangeException(
                nameof(Dia),
                $"O mês {Mes} em anos NÃO bissextos possui no máximo 28 dias");
        }
    }

    public void VerData()
    {
        Console.WriteLine($"Data: {Dia}/{Mes}/{Ano}");
    }
}
