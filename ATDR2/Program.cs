using System.Globalization;

namespace ATDR2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua data de nascimento"); 
        DateTime dataNascimento = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.CurrentCulture);


        Console.WriteLine($"Olá meu nome é {nome}");
        Console.WriteLine($"Nasci em {dataNascimento:dd/MM/yyyy} e estou aprendendo C#");
        
    }
}