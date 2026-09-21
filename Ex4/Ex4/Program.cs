namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua data de nascimento: ");
            string dataDigitada = Console.ReadLine();

            DateTime dataNascimento = DateTime.Parse(dataDigitada);
            DateTime hoje = DateTime.Today;

            int anos = hoje.Year - dataNascimento.Year;

            DateTime proximoAniversario = dataNascimento.AddYears(anos);

            if (proximoAniversario < hoje)
            {
                proximoAniversario = proximoAniversario.AddYears(1);
            }

            TimeSpan diferenca = proximoAniversario - hoje;
            int dias = diferenca.Days;

            Console.WriteLine(
                $"Seu próximo aniversário será em " +
                $"{proximoAniversario:dd/MM/yyyy}."
            );

            Console.WriteLine(
                $"Faltam {dias} dias para o seu próximo aniversário."
            );

            if (dias < 7)
            {
                Console.WriteLine("Seu aniversário está chegando! 🎉");
            }
        }
    }
}
