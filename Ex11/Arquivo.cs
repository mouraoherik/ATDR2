namespace Ex11;


public class Arquivo
{
    private StreamWriter _sw;
    private StreamReader _sr;
    private string _nome;


    public void CriaAbreArquivo()
    {
        _sw = new StreamWriter("contatos.txt", true);
    }

    public void GravarLinha(string linha)
    {
        _sw.WriteLine(linha);
    }

    public void FecharSalvarArquivo()
    {
        _sw.Close();
    }

    public List<Contato> LerArquivo()
    {
        List<Contato> contatos = new List<Contato>();
        
        if (!File.Exists("contatos.txt"))
        {
            Console.WriteLine("Nenhum contato cadastrado");
            return contatos;
        }
        
        _sr = new StreamReader("contatos.txt");
        string linha = _sr.ReadLine();

        if (linha == null)
        {
            Console.WriteLine("Nenhum contato cadastrado");
            return contatos;
        }

        while (linha != null)
        {
            string[] dados = linha.Split(",");

            if (dados.Length == 3)
            {
                contatos.Add(new Contato(dados[0], dados[1], dados[2]));
            }

            linha = _sr.ReadLine();
        }

        _sr.Close();
        return contatos;
    }
}