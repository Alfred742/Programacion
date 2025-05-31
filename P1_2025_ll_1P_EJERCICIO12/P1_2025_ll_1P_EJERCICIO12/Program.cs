using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_2025_ll_1P_EJERCICIO12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CICLOS QUE SE EJECUTAN ALEMENOS UNA VEZ
            int opcion;
            do 
            {
                Console.WriteLine("1 - Sumar");
                Console.WriteLine("2 - Restar");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("Seleccione una opcion");
                opcion = int.Parse(Console.ReadLine());

            }
                while (opcion  != 0);
            Console.ReadLine();


        }
    }
}
