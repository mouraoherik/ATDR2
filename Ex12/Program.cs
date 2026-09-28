namespace Ex12;

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

                    if (string.IsNullOrWhiteSpace(contatoNome) || string.IsNullOrWhiteSpace(contatoTelefone) || string
                            .IsNullOrWhiteSpace(contatoEmail))
                    {
                        throw new Exception("Nenhum campo pode ficar em branco");
                    }

                    if (contatoNome.Contains(",") || contatoEmail.Contains(",") || contatoTelefone.Contains(","))
                    {
                        throw new Exception("Nenhum campo conter virgulas");
                    }

                    arq.CriaAbreArquivo();
                    arq.GravarLinha(linha);
                    arq.FecharSalvarArquivo();
                    break;

                case "2":
                    Console.WriteLine("============== Digite o formato de exibição ==============");
                    Console.WriteLine("1.Somente o texto\n2.Markdown\n3.Tabela");
                    string opcaoFormatacao = Console.ReadLine();

                    switch (opcaoFormatacao)
                    {
                        case "1":
                            ContatoFormatter rawtext = new RawTextFormatter();
                            rawtext.ExibirContatos(arq.LerArquivo());
                            break;
                        case "2":
                            ContatoFormatter markdown = new MarkdownFormatter();
                            markdown.ExibirContatos(arq.LerArquivo());
                            break;
                        case "3":
                            ContatoFormatter tabela = new TabelaFormatter();
                            tabela.ExibirContatos(arq.LerArquivo());
                            break;
                        default:
                            Console.WriteLine("Opcao Invalida. Retornando para o menu");
                            break;
                    }
                    

                    break;
                case "3":
                    break;
            }
        }
    }
}