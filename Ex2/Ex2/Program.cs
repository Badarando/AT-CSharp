using System.Runtime.CompilerServices;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine(); //faço a leitura  do nome completo e guardo na variavel nome;

            char[] letras = nome.ToCharArray(); //Aqui eu guardo cada letra no array letras;

            for(int i = 0; i < letras.Length; i++) //Defino a quantidade de vezes que o for vai percorrer o array, que é a quantidade de letras presente no array letras.
            {
                if (letras[i] == ' ') //peço pra que o programa ignore os espaços e continue rodando o código
                {
                    continue;
                }

                int codigo = letras[i]; // aqui eu pego e armazeno cada letra na variavel int código, fazendo ja essa conversão de char para int.
                codigo = codigo + 2; //peço pra que ele adicione + 2 a letra

                letras[i] = (char)codigo; //transformo o código novamente em caractere
            }

            string nomeCriptografado = new string(letras); //aqui eu puxo as letras pro meu new string formando o nome codificado com cada letra alterada.

            Console.WriteLine($"Nome criptografado: {nomeCriptografado}");


        }
    }
}
