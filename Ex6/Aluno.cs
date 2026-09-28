namespace Ex6;

public class Aluno
{
    public string Nome;
    public string Matricula;
    public string Curso;
    public double Media;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}\nCurso: {Curso}\nMatricula: {Matricula}\nMedia: {Media}");
    }

    public void VerificarAprovacao()
    {
        if (Media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else Console.WriteLine("Reprovado");
    }
}