using System.Globalization;

namespace Ex5;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insira a data atual");
        DateTime dataAtual = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.CurrentCulture);
        DateTime dataFormatura = new DateTime(2028, 6, 22);
        
        
        
        if (dataAtual > DateTime.Now)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
        }
        else
        {
            int anos = Math.Abs(dataAtual.Year - dataFormatura.Year);
            int meses = Math.Abs(dataAtual.Month - dataFormatura.Month);
            int dias = Math.Abs(dataAtual.Day - dataFormatura.Day);
        
            Console.WriteLine($"{anos} Anos {meses} Meses e {dias} dias");

            if (dataAtual.AddMonths(6) >= dataFormatura)
            {
                Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
            }
            else if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
            }
        }
       
    }
}