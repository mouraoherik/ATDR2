namespace Ex8;

public class Gerente : Funcionario
{
    public Gerente(string nome, string cargo, decimal salario) : base(nome, cargo, salario * 1.10m)
    {
    }
}