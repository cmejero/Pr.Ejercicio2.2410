using edu.Ejercicio2._2410.Servicios;
using System.Security.Cryptography;

namespace edu.Ejercicio2._2410.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperacionInterfaz oi = new OperacionImplementacion();
            MenuInterfaz mi = new MenuImplementacion();

            int ni = mi.numeroEntero();
            double nd = mi.numeroDouble();

            oi.menuOp(ni, nd);

           
            




        }
    }
}