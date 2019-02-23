using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCajero
{
    class Program
    {
        static void Main(string[] args)
        {
            int cajero = 0;
            while (cajero == 0)
            {
                Console.WriteLine("Bienvenidos al mejor cajero del mundo");
                Console.WriteLine("Digite el monto en euros");
                int monto = 0;
                monto = int.Parse(Console.ReadLine());
                int residuo = 0;
                if (monto >= 500)
                {
                    Console.WriteLine(monto / 500 + " billetes de 500");
                    residuo = monto % 500;
                }
                else
                {
                    residuo = monto;
                }
                if (residuo >= 200)
                {
                    Console.WriteLine(residuo / 200 + " billetes de 200");
                    residuo = residuo % 200;
                }
                Console.WriteLine("Digite el 1 si quiere salir");
                cajero = int.Parse(Console.ReadLine());
            }
        }
    }
}
