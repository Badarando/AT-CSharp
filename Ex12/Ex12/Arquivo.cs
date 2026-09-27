using System;
using System.Collections.Generic;
using System.Text;

namespace Ex12
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
            while (linha != null)
            {
                quantidade++;
                linha = _sr.ReadLine();
            }

            _sr.Close();
            return quantidade;
        }

        public List<Contato> LerArquivo()
        {
            List<Contato> contatos = new List<Contato>();

            if (!File.Exists("C:\\Arquivos\\Contatos.txt"))
            {
                return contatos;
            }

            using (StreamReader reader =
                new StreamReader("C:\\Arquivos\\Contatos.txt"))
            {
                string linha = reader.ReadLine();

                while (linha != null)
                {
                    string[] dados = linha.Split(',');

                    if (dados.Length == 3)
                    {
                        Contato contato = new Contato(
                            dados[0], dados[1], dados[2]);

                        contatos.Add(contato);
                    }
                    else
                    {
                        Console.WriteLine("Contato com formato inválido: " + linha);
                    }

                    linha = reader.ReadLine();
                }
            }

            return contatos;
        }

        public void FecharSalvarArquivo()
        {
            _sw.Close();
        }
    }
}
