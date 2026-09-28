using System.Globalization;

namespace Ex4;

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dataNascimento = new DateTime();   
        DateTime dataAtual = DateTime.Now;
        DateTime check = DateTime.Now.AddDays(7);
     
        Console.WriteLine("Digite sua data de nascimento");
        dataNascimento = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.CurrentCulture);
     
        int anos = Math.Abs(dataAtual.Year - dataNascimento.Year);
        int meses = Math.Abs(dataAtual.Month - dataNascimento.Month);
        int dias = Math.Abs(dataAtual.Day - dataNascimento.Day);

        DateTime aniversario = dataNascimento.AddYears(anos);   
        
        Console.WriteLine($"{anos} Anos {meses} Meses e {dias} dias");

        if ((aniversario > DateTime.Now) && (aniversario < check))
        {
            Console.WriteLine("Seu aniversario e nesta semana!!");
        }

    }
}