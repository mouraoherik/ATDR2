namespace Ex11;

public class Contato
{
    private string _nome;
    private string _telefone;
    private string _email;

    public Contato(string nome, string telefone, string email)
    {
        this._nome = nome;
        this._telefone = telefone;
        this._email = email;
    }
    
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome} | Telefone : {Telefone} | Email: {Email}");
    }

    public string Nome => _nome;

    public string Telefone => _telefone;

    public string Email => _email;
}