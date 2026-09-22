using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9
{
    internal class Produto
    {
        public Produto(string nome, int quantidade, double preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public Produto()
        {

        }

        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set;  }
        //nome, quantidade e preco 
    }
}
