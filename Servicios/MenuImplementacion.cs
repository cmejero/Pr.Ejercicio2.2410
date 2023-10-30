using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio2._2410.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int numeroEntero()
        {
            
            int num2;
            
       
            Console.WriteLine("Introduzca numero elevador");
            num2 = Convert.ToInt32(Console.ReadLine());

            
            return num2;
            
            
        }

        public double numeroDouble()
        {
            double num2;



            Console.WriteLine("Introduzca numero");
            num2 = Convert.ToDouble(Console.ReadLine());


            return num2;
        }
    }
}
