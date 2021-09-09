using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {

            int lado_a = 10, lado_b = 10 , lado_c = 7 , perimetro = lado_a + lado_b + lado_c;
            Console.WriteLine("El valor del perimetro del triangulo es:" + perimetro);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();



        }
    }
}
