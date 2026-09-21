namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Marcos";
            DateTime dataNascimento = new DateTime(1995, 8, 6);

            Console.WriteLine($"Olá, meu nome é {nome}");
            Console.WriteLine($"Nasci em {dataNascimento:dd/MM/yyyy} e estou aprendendo C#");
        }
    }
}
