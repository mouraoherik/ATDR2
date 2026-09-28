namespace Ex7;

public class ContaBancaria
{
    public string Titular;
    private decimal _saldo;

    public ContaBancaria(string titular)
    {
        Titular = titular;
        _saldo = 0;
    }

    public ContaBancaria(string titular, decimal saldo)
    {
        Titular = titular;
        _saldo = saldo;
    }

    public decimal Saldo => _saldo;


    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            _saldo = Saldo + valor;
        }
        else
        {
            Console.WriteLine("Valor Inválido de deposito");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            _saldo = Saldo - valor;
        }
        else
        {
            Console.WriteLine("Valor Inválido de deposito");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}