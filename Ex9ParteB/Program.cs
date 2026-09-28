namespace Ex9ParteB;

public class Program
{
    public static void Main(string[] args)
    {
        string opcao = " 0 ";
        Arquivo arq = new Arquivo();

        while (!opcao.Equals("3"))
        {
            Console.WriteLine("============== Escolha uma opção ==============");
            Console.WriteLine("1.Inserir Produto\n2.Listar Produtos\n3.Sair");
            
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case  "1":
                        Console.WriteLine("Digite o nome do produto");
                        string produtoNome = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade em estoque do produto");
                        int produtoEstoque = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o preço do produto");
                        decimal produtoPreco = decimal.Parse(Console.ReadLine());
                        string linha = $"{produtoNome},{produtoEstoque},{produtoPreco}";
                        arq.CriaAbreArquivo();
                        arq.GravarLinha(linha);
                        arq.FecharSalvarArquivo();
                        break;
                
                case "2":
                    Console.WriteLine("============== Listagem de produtos ==============");
                    List<Produto> listaProdutos = arq.LerArquivo();
                    foreach (Produto p in listaProdutos)
                    {
                        p.ExibirDados();
                    }
                    break;
                case "3":
                    break;
            }
        }
    }
}