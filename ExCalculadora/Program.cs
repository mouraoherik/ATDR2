namespace ExCalculadora;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero");
        double n2 = double.Parse(Console.ReadLine());
        double resultado  = 0;
        

        Console.WriteLine("Escolha uma operação\n1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão");

        String opcao = Console.ReadLine();

        if (opcao.Equals("1"))
        {
            resultado = n1 + n2;
        }
        else if (opcao.Equals("2"))
        {
            resultado = n1 - n2;
        }
        else if (opcao.Equals("3"))
        {
            resultado = n1 * n2;
        }
        else if (opcao.Equals("4"))
        {
            if (n2 == 0)
            {
                Console.WriteLine("Divisão por zero!");
                resultado = 0;
            }
            else resultado = n1 / n2;
        }
        else
        {
            Console.WriteLine("Opcao Invalida");
        }



        Console.WriteLine(resultado);
    }
}