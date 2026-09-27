using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    internal class Aluno
    {
        //Criando os atributos da classe aluno
        public string Nome; 
        public string Matricula;
        public string Curso;
        public double Media;

        public void ExibirDados() //Criação do metodo exibir dados;
        {
            Console.WriteLine($"Nome do aluno: {Nome}");
            Console.WriteLine($"Matricula do aluno: {Matricula}");
            Console.WriteLine($"Curso do aluno: {Curso}");
            Console.WriteLine($"Média das notas do aluno: {Media}");
        }

        public string VerificarAprovacao() //criação do método verificar aprovação;
        {
            if(Media >= 7) //condição para aprovação ou reprovação do aluno;
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
