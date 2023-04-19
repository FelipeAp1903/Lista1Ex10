using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotação;
            double dolar;
            double reais;

            Console.Write("coloque a cotação do dolar:");
            cotação = double.Parse(Console.ReadLine());
            Console.Write("Qual é o valor em dolares:");
            dolar = double.Parse(Console.ReadLine());
            reais = dolar * cotação;
            Console.WriteLine("O valor em reais é:{0}R$" ,reais);
        }
    }
}
