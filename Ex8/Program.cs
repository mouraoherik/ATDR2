namespace Ex8;

public class Program
{
    public static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario("Fabiane", "RH", 1450);
        Gerente g1 = new Gerente("Guilherme", "Gerente do RH",1450);
        
        f1.ExibirDados();
        g1.ExibirDados();
    }
}