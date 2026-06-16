namespace exercicios_get_set.Models.Nivel_Intermediario;

public class Voo
{
    private string _origem;

    public int NumeroVoo { get; set; }
    public string Origem
    {
        get => _origem; set
        {
            if (value == Destino)
                throw new ArgumentException(
                    "Origem e destino não podem ser iguais.");

            _origem = value;
        }
    }
    public string Destino { get; set; }

    public Voo(int numeroVoo, string destino, string origem)
    {
        NumeroVoo = numeroVoo;
        Destino = destino;
        Origem = origem;
    }

    public void InformacoesVoo()
    {
        Console.WriteLine($"Voo N°{NumeroVoo}, Origem: {Origem} - Destino: {Destino}");
    }
}