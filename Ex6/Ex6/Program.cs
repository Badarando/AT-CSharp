namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno(); //Instanciando um objeto da classe Aluno
            a.Nome = "Marcos";
            a.Matricula = "1411021066";
            a.Curso = "Análise e Desenvolvimento de Sistemas";
            a.Media = 8;

            a.ExibirDados();
            Console.WriteLine($"Situação: {a.VerificarAprovacao()}"); //Aqui eu chamo o método dentro do console.writeLine e exibo o valor retornado por ele.
        }
    }
}
