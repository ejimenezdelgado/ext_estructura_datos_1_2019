using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas = 0;
            int columnas = 0;
            Console.WriteLine("Digite la cantidad de filas");
            filas=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de columnas");
            columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[filas, columnas];

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas;columna++)
                {
                    Console.WriteLine("Digite el numero");
                    int numero = int.Parse(Console.ReadLine());
                    matriz[fila, columna] = numero;
                }
            }

            int suma = 0;
            string impresion = "";
            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    suma = suma+matriz[fila, columna];
                    impresion = impresion +" " + matriz[fila, columna];
                }
                Console.WriteLine(impresion);
                impresion = "";
            }
            Console.WriteLine("La suma total es "+suma);
            Console.ReadLine();
        }
    }
}
