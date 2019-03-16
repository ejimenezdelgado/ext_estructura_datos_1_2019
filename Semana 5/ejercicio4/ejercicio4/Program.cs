using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            while (contador<=200)
            {
                if (contador%2 == 0)
                {
                    Console.WriteLine("Este numero es par "+contador);
                }
                contador = contador + 1;
            }
            Console.ReadLine();

        }
    }
}
