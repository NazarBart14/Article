using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_stryktyru
{
    struct Article
    {
        public double Kod;
        public string Name;
        public double Money;

        public Article(double kod, double money , string name) : this()
        {
            Kod = kod;
            Money = money;
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine($"Money {Money}, Kod {Kod}, Name {Name}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double kod = 734235235, money = 1999;
            string name = "Call of Duti: Warzon";
            Article article = new Article(kod, money, name);
            article.Print();
        }
    }

}
