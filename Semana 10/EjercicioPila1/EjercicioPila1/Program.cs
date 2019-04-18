using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPila1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El mejor sistemita");
            int cantidad = 0;
            Console.WriteLine("Digite la cantidad de numero");
            cantidad = Int32.Parse(Console.ReadLine());
            int digitado = 0;
            int suma = 0;

            Stack miPila = new Stack();

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Digite el numero");
                digitado = int.Parse(Console.ReadLine());
                miPila.Push(digitado);
            }
            for (int i = 0; i < cantidad; i++)
            {
                suma = suma + int.Parse(miPila.Pop() + "");
            }
            Console.WriteLine("La suma " + suma);
            Console.ReadLine();
        }
    }
}
