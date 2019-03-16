using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 1;
            Console.WriteLine("Digite el numero de tabla");
            numero=int.Parse(Console.ReadLine());
            while (contador<=12)
            {
                Console.WriteLine(numero+" * "+contador 
                    +" = "+ numero* contador);
                contador = contador + 1;
            }
            Console.ReadLine();
        }
    }
}
