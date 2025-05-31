using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2025_II_1P_EJERCICIO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construir un programa en donde solicite el nombre del alumnno, la seleccion y la clase.
            // Luego sus 3 notas, poteriormente se requiere calcular el promedio de esas 3 notas.
            // para mostrarlas en pantallas

            String nombreAlumno, nombreClase;
            char seccion;
            int nota1, nota2, nota3;
            decimal promedio;
            Console.WriteLine($"Ingrese l nombre de alumno: ");
            nombreAlumno = Console.ReadLine();
            Console.WriteLine($"ingrese el nombre de la clase: ");
            nombreClase = Console.ReadLine();   
            Console.WriteLine($"Ingrese la seccion: ");
            seccion = char.Parse(Console.ReadLine());
        }
    }
}
