namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(); //instanciando os objetos 
            f.Nome = "João";
            f.Cargo = "Analista";
            f.SalarioBase = 2500;

            Gerente e = new Gerente();
            e.Nome = "Pedro";
            e.Cargo = "Gerente";
            e.SalarioBase = 2500;

            Console.WriteLine($"Salário do {f.Cargo} {f.Nome}, R$: {f.SalarioBase:F2}");
            Console.WriteLine($"Salário do {e.Cargo} {e.Nome}, R$: {e.SalarioBonus():F2}"); //chamando o método bonus
        }


    }
}
