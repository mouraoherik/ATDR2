namespace Ex6;

public class Program
{
    public static void Main(string[] args)
    {
        Aluno a1 = new Aluno();

        a1.Media = 7.5;
        a1.Nome = "Joao";
        a1.Curso = "Engenharia De Software";
        a1.Matricula = "EDS-1234";
        
        a1.ExibirDados();
        a1.VerificarAprovacao();
    }
}