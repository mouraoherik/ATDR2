namespace Exer10;

public class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSorteado, n1;
        int tentativas = 0;

        numeroSorteado = random.Next(1, 51);

        while (tentativas < 5)
        {
            Console.WriteLine("Digite um numero");
            try
            {
                n1 = int.Parse(Console.ReadLine());

                if (n1 < 1 || n1 > 50)
                {
                    throw
                        new ArgumentOutOfRangeException(
                            nameof(n1), "O número digitado está fora do intervalo permitido (1 a 50).");
                }

                if (numeroSorteado > n1)
                {
                    Console.WriteLine("O Numero sorteado e maior!");
                }
                else if (numeroSorteado < n1)
                {
                    Console.WriteLine("O Numero sorteado e menor!");
                }
                else if (numeroSorteado == n1)
                {
                    Console.WriteLine("Voce acertou!!");
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada digitada não é um numero");
                tentativas--;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Erro de intervalo");
                tentativas--;
            }
            

            tentativas++;
        }
    }
}