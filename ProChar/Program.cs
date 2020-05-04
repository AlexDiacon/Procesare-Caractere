using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Procesare_caractere
{
    class ProcessChar
    {
        public List<string> fileContent;

        public void Reading()
        {
            string filePath = @"C:\Users\User\source\repos\ProChar\Text.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            fileContent = lines;
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        public void nrChar()
        {
            int total = 0;
            foreach (string s in fileContent)
            {
                foreach (char c in s)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        total++;
                    }
                }
            }
            Console.WriteLine("Numarul total de caractere din fisierul text = " + total);
        }
        public void Vocale()
        {
            int voc = 0;
            string vocale = "aeiouAEIOU";
            foreach (string s in fileContent)
            {
                foreach (char c in s)
                {
                    if (vocale.IndexOf(c) >= 0)
                    {
                        voc++;
                    }
                }
            }
            Console.WriteLine("Numarul de vocale din fisierul text = " + voc);
        }
        public void Consoane()
        {
            int cons = 0;
            string consoane = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            foreach (string s in fileContent)
            {
                foreach  (char c in s)
                {
                    if (consoane.IndexOf(c) >= 0)
                    {
                        cons++;
                    }
                }
            }
            Console.WriteLine("Numarul de consoane din fisierul text = " + cons);
        }
        public void Linii()
        {
            int linii = 0;
            using (var reader = File.OpenText(@"C:\Users\User\source\repos\ProChar\Text.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    linii++;
                }
            }
            Console.WriteLine("Numarul de linii din fisierul text = " + linii);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProcessChar text = new ProcessChar();
            text.Reading();
            Console.WriteLine();
            text.nrChar();
            text.Vocale();
            text.Consoane();
            text.Linii();
        }
    }
}