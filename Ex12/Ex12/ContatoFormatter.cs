using System;
using System.Collections.Generic;
using System.Text;

namespace Ex12
{
    internal class ContatoFormatter
    {
        public virtual void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("Formato de exibição não definido.");
        }
    }
}
