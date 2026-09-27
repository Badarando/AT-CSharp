using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7
{
    internal class ContaBancaria
    {
        public string Titular; //criando os atributos titular e saldo
        private decimal _saldo;

        public decimal Depositar(decimal valor) //criação do método depositar
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
                return _saldo;
            }
            else
            {
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado com sucesso!");
                return _saldo += valor;
            }
                
            
        }
        public decimal Sacar(decimal valor) //criação do método sacar
        {
            if(valor <= 0)
            {
                Console.WriteLine("O valor do saque deve ser positivo!");
                return _saldo;
            }
            else if (valor > Saldo)
            { 
                Console.WriteLine($"Tentativa de saque: R$ {valor:F2}\nSaldo insuficiente para realizar o saque!");
                return _saldo;
            }
            else
            {
                Console.WriteLine($"Saque de R$ {valor:F2} realizado com sucesso!");
                return _saldo -= valor;
            }
                
        }

        public void ExibirTitular() //criação do método exibir titular, sei que não foi pedido mas achei melhor colocar devido ao exemplo de saída no enunciado
        {
            Console.WriteLine($"Titular: {Titular}");
        }

        public void ExibirSaldo() //criação do método ExibirSaldo
        {
            Console.WriteLine($"Saldo atual: R$ {Saldo:F2}");
        }
    }
}
