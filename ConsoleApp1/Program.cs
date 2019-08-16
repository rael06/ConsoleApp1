using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "programmation \"C#\"";
//            string str2 = "\tC:\\Windows\\cible.txt";
//
//            char[] tab = {'p', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'a', 't', 'i', 'o', 'n', ' ', 'C', '#'};
//            string str3 = new string(tab);
//            Console.WriteLine(str2);
//
//            //Bienvenue en programmation C#.
//
//            StringBuilder str4 = new StringBuilder();
//            str4.Append("Bienvenue ");
//            str4.Append("en \n");
//            str4.Append(str1);
//            str4.Insert(10, "à tous ");
//            Console.WriteLine(str4);

            int x = 23, y = 45;
            Console.WriteLine(x.ToString() + y.ToString());

            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            Console.WriteLine(date.ToString("f"));
            Console.WriteLine("Nous sommes le : {0}", date);
            Console.WriteLine("Nous sommes le : {0:d}", date);

            double valeur = 123;
            Console.WriteLine(valeur.ToString("00000"));
            Console.WriteLine(string.Format("{1:d},{0:0000}", valeur, date));

            Console.WriteLine(str1.Length);
            Console.WriteLine("Le troisième caractère est {0}", str1[2]);
            Console.WriteLine("L'index de o est : {0}", str1.IndexOf("o", StringComparison.Ordinal));
            Console.WriteLine(str1.Substring(4));
            Console.WriteLine(str1.Trim());
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.Trim().Replace('o', 'y').Substring(4).ToUpper());
        }
    }
}
