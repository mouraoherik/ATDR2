namespace Ex9ParteB;

public class Arquivo
{
    private StreamWriter _sw;
    private StreamReader _sr;
    private string _nome;
    

    public void CriaAbreArquivo()
    {
        _sw = new StreamWriter("estoque.txt", true);
    }

    public void GravarLinha(string linha)
    {
        _sw.WriteLine(linha);
    }

    public void FecharSalvarArquivo()
    {
        _sw.Close();
    }

    public List<Produto> LerArquivo()
    {
        List<Produto> produtos = new List<Produto>();
        

        if (!File.Exists("estoque.txt"))
        {
            Console.WriteLine("Nenhum produto cadastrado");
            return produtos;
        }
        
        _sr = new StreamReader("estoque.txt");

        string linha = _sr.ReadLine();
        
        if (linha == null)
        {
            Console.WriteLine("Nenhum produto cadastrado");
            return produtos;
        }
        
        
        while (linha != null)
        {
            string[] dados = linha.Split(",");

            if (dados.Length == 3)
            {
                produtos.Add(new Produto(dados[0],int.Parse(dados[1]),decimal.Parse(dados[2])));   
            }
            
            linha = _sr.ReadLine();
        }
        _sr.Close();
        return produtos;
    }
    
}