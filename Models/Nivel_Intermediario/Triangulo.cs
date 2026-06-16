namespace exercicios_get_set.Models.Nivel_Intermediario;

public class Triangulo
{
    private double _ladoA;
    private double _ladoB;
    private double _ladoC;


    private double LadoA
    {
        get => _ladoA; set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Lado deve ter valor maior que 0"
                );

            _ladoA = value;
        }
    }
    private double LadoB
    {
        get => _ladoB; set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Lado deve ter valor maior que 0"
                );

            _ladoB = value;
        }
    }
    private double LadoC
    {
        get => _ladoC; set
        {
            if (value <= 0)
                throw new ArgumentException(
                    "Lado deve ter valor maior que 0"
                );

            _ladoC = value;
        }
    }
    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;

        if (!ValidarTriangulo())
            throw new ArgumentException(
                "Triângulo inválido"
            );
    }

    public bool ValidarTriangulo()
    {
        return LadoA < LadoB + LadoC
        && LadoB < LadoA + LadoC
        && LadoC < LadoA + LadoB;
    }
}
