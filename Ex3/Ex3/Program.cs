namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação matemática:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operacao = int.Parse(Console.ReadLine());

            string resultado = operacao switch
            {
                1 => (num1 + num2).ToString(),
                2 => (num1 - num2).ToString(),
                3 => (num1 * num2).ToString(),

                4 when num2 != 0 =>
                    ((double)num1 / num2).ToString(),

                4 => "Não é possível dividir por zero.",

                _ => "Operação inválida."
            };

            Console.WriteLine($"Resultado da operação: {resultado}");
        }
    }
}
      