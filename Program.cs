using Proyecto_Programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("//Bienvenido a mi servicio\\");
            Console.WriteLine("Seleccione e tipo de vehiculo");
            Console.WriteLine("1.Coche");
            Console.WriteLine("2.Moto");
            int eleccion = int.Parse(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    vehiculo micoche = new coche();
                    micoche.realizarmantenimiento();
                    Console.WriteLine("costo de mantenimiento del coche: $" + micoche.obtenercostomantenimiento());
                    Servicio cambioaceite = new cambioAceite();
                    cambioaceite.realizarServicio();
                    Console.WriteLine("EL costo de cambio de aceite es: $" + cambioaceite.calcularCosto());
                    micoche.lavar();
                    Console.WriteLine("************Tiempo del Servicio*********");
                    vehiculo Vehiculo = new vehiculo();
                    Console.WriteLine("El tiempo del servicio es:" + Vehiculo.tiempo() + "Horas");
                    Console.WriteLine("/////////////////////////////////////////////////////////");


                    break;

                case 2:
                    vehiculo moto = new vehiculo.moto();
                    moto.realizarmantenimiento();
                    Console.WriteLine("costo de mantenimiento de la moto $" + moto.obtenercostomantenimiento());
                    reparacionFrenos reparacionFrenos = new reparacionFrenos();
                    reparacionFrenos.realizarServicio();
                    Console.WriteLine("Costo de cambio de frenos $" + reparacionFrenos.calcularCosto());
                    Console.WriteLine("************Tiempo del Servicio*********");
                    vehiculo Moto = new vehiculo.moto();
                    Console.WriteLine("El tiempo del servicio es:" + Moto.tiempo() + "Horas");
                    Console.WriteLine("/////////////////////////////////////////////////////////");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
