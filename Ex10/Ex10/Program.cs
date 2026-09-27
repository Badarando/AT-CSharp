namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 51);
            int tentativas = 0;

            Console.WriteLine("Adivinhe o número de 1 a 50!");
            Console.WriteLine("Você tem 5 tentativas.");

            while (tentativas < 5)
            {
                Console.Write($"\nTentativa {tentativas + 1}/5 - Digite seu palpite: ");

                int palpite;

                try
                {
                    palpite = int.Parse(Console.ReadLine() ?? "");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: digite um número inteiro.");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Erro: número grande demais.");
                    continue;
                }

                if (palpite < 1 || palpite > 50)
                {
                    Console.WriteLine("Erro: o número deve estar entre 1 e 50.");
                    continue;
                }

                tentativas++;

                if (palpite == numeroSecreto)
                {
                    Console.WriteLine($"Você acertou em {tentativas} tentativa(s)!");
                    break;
                }
                else if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor.");
                }
            }

            if (tentativas == 5)
            {
                Console.WriteLine($"Fim de jogo! O número era {numeroSecreto}.");
            }
        }
    }
}
