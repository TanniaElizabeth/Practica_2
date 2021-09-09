using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        
        //Crear tres variables int y dar valores estáticos
        //crear variable int la cual guarda la suma de las tres
        //mostrar en pantalla el valor de suma
        static void Main(string[] args)
        {

            int numero_1 = 5, numero_2 = 10, numero_3=20;
            int suma = numero_1 + numero_2 + numero_3;
            Console.WriteLine("El valor de suma es:" + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
       
            



        }
    }
}
