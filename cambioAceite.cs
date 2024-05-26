using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class cambioAceite : Servicio
    {
        public override void realizarServicio()
        {
            Console.WriteLine("Realizando cambio de aceite");
        }
        public override double calcularCosto()
        {
            return 50.0;
        }
    }
}
