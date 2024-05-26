using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp3
{
    public class coche : vehiculo
    {
        public override void realizarmantenimiento()
        {
            Console.WriteLine("realizar cambio de freno y aceite");
        }
        public override double obtenercostomantenimiento()
        {
            return 150.0;
        }
        public new void lavar()
        {
            Console.WriteLine("lavando el coche con cera y shampoo");
        }
      

    }
}