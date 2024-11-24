using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_geriye_deger_donduren_metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            isl.topla(9, 12);
            isl.topla(10, 13);

            Console.WriteLine("\n");

            isl.kare(9);
            Console.Read();
        }
    }
}
