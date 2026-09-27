using System.Collections.Generic;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Arquivo a = new Arquivo();

            while (true)
            {
                Console.WriteLine("=== Gerenciador de Contatos ===");
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar Contatos cadastrados");
                Console.WriteLine("3 - Sair");

                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Digite uma operação válida!");
                    continue;
                }

                if (op == 1)
                {
                    Contato c = new Contato();

                    Console.WriteLine("Digite o nome do contato: ");
                    c.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o telefone do contato: ");
                    c.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o email do contato: ");
                    c.Email = Console.ReadLine();

                    string linha;
                    linha = $"{c.Nome},{c.Telefone},{c.Email}";
                    a.CriaAbreArquivo();
                    a.GravarLinha(linha);
                    a.FecharSalvarArquivo();
                    Console.WriteLine("Contato cadastrado com sucesso!");
                }
                else if (op == 2)
                {
                    List<Contato> contatos = a.LerArquivo();

                    if (contatos.Count == 0)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Escolha o formato de exibição:");
                        Console.WriteLine("1 - Markdown");
                        Console.WriteLine("2 - Tabela");
                        Console.WriteLine("3 - Texto Puro");

                        if (!int.TryParse(Console.ReadLine(), out int formato))
                        {
                            Console.WriteLine("Formato inválido!");
                            continue;
                        }

                        ContatoFormatter formatter;

                        if (formato == 1)
                        {
                            formatter = new MarkdownFormatter();
                        }
                        else if (formato == 2)
                        {
                            formatter = new TabelaFormatter();
                        }
                        else if (formato == 3)
                        {
                            formatter = new RawTextFormatter();
                        }
                        else
                        {
                            Console.WriteLine("Formato inválido!");
                            continue;
                        }

                        formatter.ExibirContatos(contatos);
                    }
                }
                else if (op == 3)
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Digite uma operação válida!");
                }
            }
        }
    }
}
