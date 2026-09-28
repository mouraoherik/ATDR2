namespace Ex9;

public class Program
{
    public static void Main(string[] args)
    {
        List<Produto> estoqueArray = new List<Produto>();
        string opcao = " 0 ";

        while (!opcao.Equals("3"))
        {
            Console.WriteLine("============== Escolha uma opção ==============");
            Console.WriteLine("1.Inserir Produto\n2.Listar Produtos\n3.Sair");
            
            opcao = Console.ReadLine();

            switch (opcao)
            {
              case  "1":

                  if (estoqueArray.Count < 5)
                  {
                      Console.WriteLine("Digite o nome do produto");
                      string produtoNome = Console.ReadLine();
                      Console.WriteLine("Digite a quantidade em estoque do produto");
                      int produtoEstoque = int.Parse(Console.ReadLine());
                      Console.WriteLine("Digite o preço do produto");
                      decimal produtoPreco = decimal.Parse(Console.ReadLine());
                      estoqueArray.Add(new Produto(produtoNome,produtoEstoque,produtoPreco));
                      break;
                  }

                  Console.WriteLine("Limite de produtos atingido!");
                  break;
              case "2":
                  Console.WriteLine("============== Listagem de produtos ==============");
                  foreach (Produto produto in estoqueArray)
                  {
                      produto.ExibirDados();
                  }
                  break;
              case "3":
                  break;
            }
        }
    }
}

