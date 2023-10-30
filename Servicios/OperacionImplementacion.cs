using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.Ejercicio2._2410.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    { 
        public void menuOp(int ni, double nd)
        {
            double aux = 1;
           for(int n=0; n< ni; n++)
            {
                aux= aux*nd;
            }
           Console.WriteLine(aux);
        }
    }
}
