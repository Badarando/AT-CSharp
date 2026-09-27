namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c = new ContaBancaria(); //instanciando objeto
            //atribuindo titular
            c.Titular = "Marcos Badaró";

            //chamando metodos
            c.ExibirTitular();
            c.Depositar(500);
            c.ExibirSaldo();
            c.Sacar(700);
            c.Sacar(200);
            c.ExibirSaldo();
        }
    }
}
