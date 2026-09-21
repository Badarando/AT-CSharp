namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFormatura = new DateTime(2028, 12, 15);

            Console.WriteLine("Digite a data atual (dd/MM/yyyy): ");
            DateTime dataAtual = DateTime.Parse(Console.ReadLine());

            if (dataAtual > DateTime.Today)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            }

            else if (dataAtual > dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
            }
            else
            {
                int anos = 0;
                int meses = 0;

                DateTime dataCalculada = dataAtual;


                while (dataCalculada.AddYears(1) <= dataFormatura)
                {
                    dataCalculada = dataCalculada.AddYears(1);
                    anos++;
                }


                while (dataCalculada.AddMonths(1) <= dataFormatura)
                {
                    dataCalculada = dataCalculada.AddMonths(1);
                    meses++;
                }


                int dias = (dataFormatura - dataCalculada).Days;

                Console.WriteLine(
                    $"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!"
                );


                if (dataAtual.AddMonths(6) > dataFormatura)
                {
                    Console.WriteLine(
                        "A reta final chegou! Prepare-se para a formatura!"
                    );
                }
            }
        }
    }
}
