using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8
{
    internal class Gerente : Funcionario //extendendo a classe funcionario, dizendo que a classe gerente é filha dela.
    {

        public decimal SalarioBonus() //criando o método bonus que vai diferenciar o salario de gerente para o de funcionário
        {
            decimal bonus = (SalarioBase * 20) / 100; //SalarioBase é um atributo herdado da classe Funcionario
            return SalarioBase + bonus;
        }
    }
}
