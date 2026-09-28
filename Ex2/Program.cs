namespace Ex2;

public class Program
{
    public static void Main(string[] args)
    {
        
        char[] alfabeto = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        ];

        Console.WriteLine("Digite seu nome:");
        string input = Console.ReadLine();

        char[] nomeArray = input.ToCharArray();

        char[] nomeCifrado = new char[nomeArray.Length];

        for (int i = 0; i < nomeCifrado.Length; i++)
        {
            if (char.IsLetter(nomeArray[i]))
            {
                if (char.IsUpper(nomeArray[i]))
                {
                    int indexLetra = Array.IndexOf(alfabeto, char.ToLower(nomeArray[i]));
                    int indexNovoLetra = (indexLetra + 2) % 26;
                    char letraCifrada = alfabeto[indexNovoLetra];
                    letraCifrada = char.ToUpper(letraCifrada);
                    nomeCifrado[i] = letraCifrada;
                }
                else
                {
                    int indexLetra = Array.IndexOf(alfabeto, nomeArray[i]);
                    int indexNovoLetra = (indexLetra + 2) % 26;
                    char letraCifrada = alfabeto[indexNovoLetra];
                    nomeCifrado[i] = letraCifrada;
                }
            }
            else nomeCifrado[i] = ' ';
        }

        string resultadoCifrado = String.Join("", nomeCifrado);

        Console.WriteLine(resultadoCifrado);
    }
}