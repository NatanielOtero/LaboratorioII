using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion av = new Avion(100, 2000);
            Carreta car = new Carreta(100);
            Deportivo depor = new Deportivo(100,"",10);
            Console.WriteLine(Gestion.MostrarImpuestoNacional(av));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial((IARBA)av));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(car));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(depor));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial((IARBA)depor));
            Console.ReadKey();

        }
    }
}
