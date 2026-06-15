namespace exercicios_get_set.Models;

public class Aluno
{
    private double _nota;


    private string? Nome { get; set; }
    private string? Matricula { get; set; }
    private double Nota
    {
        get => _nota; set
        {
            if (value >= 0 && value <= 10)
            {
                _nota = value;
            }
            else
            {
                Console.WriteLine("São aceitas apenas notas entre 0 e 10. Nota definida como 0");
            }
        }
    }
    public Aluno(string? nome, string? matricula, double nota)
    {
        Nome = nome;
        Matricula = matricula;
        Nota = nota;
    }

    public void ExibirDadosAluno()
    {
        Console.WriteLine($"Aluno: {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Nota: {Nota}");
    }
}