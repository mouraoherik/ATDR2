namespace Ex7;

public class Program
{
    public static void Main(string[] args)
    {
        ContaBancaria c1 = new ContaBancaria("Joao");
        
        c1.Depositar(250);
        c1.ExibirSaldo();
        c1.Sacar(100);
        c1.ExibirSaldo();
        c1.Depositar(-200);
    }
}