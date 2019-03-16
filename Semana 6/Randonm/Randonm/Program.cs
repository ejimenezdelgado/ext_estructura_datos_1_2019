using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randonm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.WriteLine("Digite un numero para la loteria");
            numero=int.Parse(Console.ReadLine());
            bool valido = false;
            int contador = 0; 
            while (valido == false)
            {
                Random oRandom = new Random();
                int numeroRandom = oRandom.Next(1, 10);
                if (numeroRandom == numero)
                {
                    Console.WriteLine("La cantidad de intentos fue "
                        + contador);
                    valido = true;
                }
                contador=contador + 1;
            }
            Console.ReadLine();




        }
    }
}
