using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int edad = 0;
            double salario = 0;
            double salarioTotal = 0;

            Console.WriteLine("Digite el nombre de la persona");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite la edad de la persona");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el sueldo inicial");
            salario = Double.Parse(Console.ReadLine());

            while (65-edad>=1 )
            {
                edad = edad + 1;
                salario = salario + (salario * 0.05);
                salarioTotal = salarioTotal+salario;
                Console.WriteLine("Edad:"+edad +"-"+ salarioTotal);
            }
            Console.WriteLine("El nombre es "+nombre);
            Console.WriteLine("El salario final es " + salarioTotal);
            Console.ReadLine();
        }
    }
}
