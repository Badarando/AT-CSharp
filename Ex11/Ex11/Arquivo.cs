using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ex11
{
    internal class Arquivo
    {
        private StreamWriter _sw;
        private StreamReader _sr;
        public void CriaAbreArquivo()
        {
            Directory.CreateDirectory("C:\\Arquivos");
            _sw = File.AppendText("C:\\Arquivos\\Contatos.txt");
        }

        public void GravarLinha(string linha)
        {
            _sw.WriteLine(linha);
        }

        public int ContarContatos()
        {
            if (!File.Exists("C:\\Arquivos\\Contatos.txt"))
            {
                return 0;
            }
            int quantidade = 0;
            String linha;

            _sr = new StreamReader("C:\\Arquivos\\Contatos.txt");
            linha = _sr.ReadLine();
            while(linha!= null)
            {
                quantidade++;
                linha = _sr.ReadLine();
            }

            _sr.Close();
            return quantidade;
        }

        public void LerArquivo()
        {
            if (ContarContatos() == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }

            _sr = new StreamReader("C:\\Arquivos\\Contatos.txt");
            Console.WriteLine("Contatos cadastrados: ");

            string linha = _sr.ReadLine();

            while(linha != null)
            {
                string[] dados = linha.Split(',');

                if (dados.Length == 3)
                {
                    Console.WriteLine($"Nome: {dados[0]} | Telefone: {dados[1]} | Email: {dados[2]}");
                }
                else
                {
                    Console.WriteLine("Contato com formato inválido: " + linha);
                }

                linha = _sr.ReadLine();
            }

            _sr.Close();

        }

        public void FecharSalvarArquivo()
        {
            _sw.Close();
        }
    }
}
