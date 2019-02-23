using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int cantidad = 0;
            int n = 0;
            float largo = 0;
            string linea = "";
            Console.WriteLine("Cuantas piezas procesará:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            int contador = 0;
            while (contador<n)
            {
                Console.Write("Ingrese la medida de la pieza:");
                linea = Console.ReadLine();
                largo = float.Parse(linea);
                if (largo >= 1.20 && largo <= 1.30)
                {
                    cantidad = cantidad + 1;
                }
                contador = contador + 1;
            }
            Console.Write("La cantidad de piezas aptas son:");
            Console.Write(cantidad);
            Console.ReadKey();
        }
    }
}
