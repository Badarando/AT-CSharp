using System.Xml;

namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Arquivo a = new Arquivo();

            while (true)
            {
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");
                
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {

                    if(a.ContarProdutos() >= 5)
                    {
                        Console.WriteLine("Você atingiu o limite de produtos cadastrados.");
                    }
                    else
                    {
                        Produto p = new Produto();

                        Console.WriteLine("Digite o nome do produto: ");
                        p.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a quantidade do produto: ");
                        p.Quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o preço do produto: ");
                        p.Preco = double.Parse(Console.ReadLine());

                        string linha;
                        linha = $"{p.Nome},{p.Quantidade},{p.Preco.ToString("F2").Replace(",", ".")}";
                        //linha = "Produto: " + p.Nome + ", " + "Quantidade: " + p.Quantidade + ", " + "Preco: " + $"{p.Preco:F2}";
                        Console.WriteLine("Linha: " + linha);
                        a.CriaAbreArquivo();
                        a.GravarLinha(linha);
                        a.FecharSalvarArquivo();
                    }

                }
                else if (op == 2)
                {
                    a.LerArquivo();
                }
                else if (op == 3)
                {
                    Console.WriteLine("Saindo do sistema!");
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
