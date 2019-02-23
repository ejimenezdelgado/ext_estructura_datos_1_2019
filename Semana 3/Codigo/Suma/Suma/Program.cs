using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor entre 0 y 999");
            string linea1 = Console.ReadLine();
            int x = int.Parse(linea1);
            Console.WriteLine("Ingrese un valor entre 0 y 999");
            string linea2 = Console.ReadLine();
            int y = int.Parse(linea2);
            Console.WriteLine("El resultado es: "
                + (x + y));
            Console.ReadLine();
        }
    }
}
