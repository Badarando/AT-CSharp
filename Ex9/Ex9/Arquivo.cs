using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9
{
    internal class Arquivo
    {
        private string _nome;
        private StreamWriter _sw;
        private StreamReader _sr;

        public void CriaAbreArquivo()
        {
            _sw = new StreamWriter("C:\\Arquivos\\Produtos.txt", true);
        }
        public void GravarLinha(string linha)
        {
            _sw.WriteLine(linha);
        }

        public void FecharSalvarArquivo()
        {
            _sw.Close();
        }

    }
}
