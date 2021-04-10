using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios19
{
    class Program
    {
        static void Main(string[] args)
        {
            //19. Solicite el ingreso de un número al usuario y presente la parte entera
            string numero;
            double SalidaNum;
            bool Flag = false;
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = Console.ReadLine();
                if (!double.TryParse(numero, out SalidaNum))
                {
                    Console.WriteLine("Usted debe ingresar un valor numérico");
                }
                else
                {
                    Flag = true;
                    Console.WriteLine($"El numero ingresado es {SalidaNum}" +
                       " y la parte entera es "+ Math.Round(SalidaNum));
                }
            } while (Flag==false);
            Console.WriteLine("Presione una tecla para salir");           
            Console.ReadKey();   
        }
    }
}
