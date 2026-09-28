namespace Ex8;

public class Funcionario
{
    public string Nome;
    public string Cargo;
    public decimal Salario;

    public Funcionario(string nome, string cargo, decimal salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}\nCargo: {Cargo}\nSalario: {Salario}");
    }
    
}