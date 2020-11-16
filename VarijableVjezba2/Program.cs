using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarijableVjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c,d,kalkurianje;
            Console.WriteLine("upisite 4 brojeva: ");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c=Convert.ToInt32(Console.ReadLine());
            d=Convert.ToInt32(Console.ReadLine());

            kalkurianje = Math.Pow(a,2)+ Math.Pow(b, 2)+ Math.Pow(c, 2)+ Math.Pow(d, 2);

        }
    }
}
