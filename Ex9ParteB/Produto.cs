namespace Ex9ParteB;

public class Produto
{
    private string _nome;
    private int _quantidade;
    private decimal _preco;

    public Produto(string nome, int quantidade, decimal preco)
    {
        this._nome = nome;
        this._quantidade = quantidade;
        this._preco = preco;
    }

    public decimal Preco => _preco;

    public int Quantidade => _quantidade;

    public string Nome => _nome;

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome} | Quantidade : {Quantidade} | Preço: {Preco}");
    }
}