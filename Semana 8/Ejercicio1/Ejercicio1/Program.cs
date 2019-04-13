using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al mejor " +
                              "programa del mundo");

            Console.WriteLine("Digite un numero " +
                              "para inicializar " +
                              "el arreglo");
            int numero = int.Parse(Console.ReadLine());
            int[] arreglo = new int[numero];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Digite un numero ");
                numero = int.Parse(Console.ReadLine());
                arreglo[i] = numero;
            }
            double promedio = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                promedio = promedio+ arreglo[i];
            }
            promedio = promedio/arreglo.Length;
            Console.WriteLine("El promedio es " + promedio);
            Console.ReadLine();
        }
    }
}
