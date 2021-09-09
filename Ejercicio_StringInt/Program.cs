using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre;
           

            Console.WriteLine("Cual es tu nombre?");
            nombre = Console.ReadLine();

            Console.WriteLine("Cual es tu edad?");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Te llamas " + nombre + " y tienes la edad de " + edad );
            Console.ReadKey();
        }
    }
}
