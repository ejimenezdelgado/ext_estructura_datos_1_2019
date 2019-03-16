using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumatoria = 0;
            int temporal = 1;
            int resultado = 0;
            while (resultado <= 100)
            {
                resultado = sumatoria + temporal;
                sumatoria = temporal;
                temporal = resultado;
                if (resultado <= 100)
                {
                    Console.WriteLine(resultado);
                }
            }
            Console.ReadLine();

        }
    }
}
