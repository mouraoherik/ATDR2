namespace Ex11;

public class Program
{
    public static void Main(string[] args)
    {
        string opcao = "";
        Arquivo arq = new Arquivo();

        while (!opcao.Equals("3"))
        {
            Console.WriteLine("============== Gerenciador de Contatos ==============");
            Console.WriteLine("1.Adicionar novo contato\n2.Listar Contatos\n3.Sair");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o nome do contato");
                    string contatoNome = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do contato");
                    string contatoTelefone = Console.ReadLine();
                    Console.WriteLine("Digite o email do contato");
                    string contatoEmail = Console.ReadLine();
                    string linha = $"{contatoNome},{contatoTelefone},{contatoEmail}";
                    arq.CriaAbreArquivo();
                    arq.GravarLinha(linha);
                    arq.FecharSalvarArquivo();
                    break;

                case "2":
                    Console.WriteLine("============== Contatos cadastrados ==============");
                    List<Contato> listaProdutos = arq.LerArquivo();
                    foreach (Contato p in listaProdutos)
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