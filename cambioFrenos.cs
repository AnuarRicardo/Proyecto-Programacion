using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programacion
{
    public class reparacionFrenos : Servicio
    {
        public override void realizarServicio()
        {
            Console.WriteLine("Realizando reparacion de frenos");
        }
        public override double calcularCosto()
        {
            return 100.0;
        }

    }
}
