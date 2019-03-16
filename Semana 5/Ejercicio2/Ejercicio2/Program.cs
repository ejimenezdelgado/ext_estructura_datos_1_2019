using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador =0;
            int resultado = 1;
            Console.WriteLine("Digite un numero");
            numero = int.Parse(Console.ReadLine());
            contador = numero;
            while (contador>1)
            {
                resultado = resultado * contador;
                contador = contador - 1;
            }

            Console.WriteLine("El factorial del "+numero+ 
                " es "+ resultado);
            Console.ReadLine();
        }
    }
}
