using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ConsoleApp3
{
    public class vehiculo
    {
        public virtual void realizarmantenimiento()
        {
            Console.WriteLine("realizando mantenimiento general al vehiculo");
        }
        public virtual double obtenercostomantenimiento()
        {
            return 50.0;
        }
        public void lavar()
        {
            Console.WriteLine("lavando el coche");
        }
        public virtual double tiempo()
        {
            return 4;
        }
       
           public class moto : vehiculo
        {
            public override void realizarmantenimiento()
            {
                Console.WriteLine("realizar cambio de ruedas y revision de neumaticos");
            }
            public override double obtenercostomantenimiento()
            {
                return 100.0;
            }
            public override double tiempo()
            {
                return 2;
            }


        }
    }
} 