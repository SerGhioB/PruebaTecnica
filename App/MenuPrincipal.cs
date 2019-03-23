using System;
using SergioBoror.Model;
using SergioBoror.Interfaz;
using System.Collections.Generic;

namespace SergioBoror.App
{
    public class MenuPrincipal
    {
        public List<Vehiculo> DetalleVehiculo { get; set; }

        public MenuPrincipal()
        {
            this.DetalleVehiculo = new List<Vehiculo>();

        }

        public void MostrarMenu()
        {
            var opcion = 100;
            do
            {
                try
                {
                    Console.WriteLine("1. crear objeto Avion");
                    Console.WriteLine("2. crear objeto Submarino");
                    Console.WriteLine("3. Mostrar informacion Aviones");
                    Console.WriteLine("4. Mostrar informacion submarinos");
                    Console.WriteLine("0 Salir");
                    Console.WriteLine("Ingrese su opcion");
                    string valor = Console.ReadLine();
                    opcion = Convert.ToInt16(valor);

                    if (opcion == 1)
                    {
                        objetoAvion(opcion);
                    }
                    else if (opcion == 2)
                    {
                        objetoSubmanrio(opcion);
                    }
                    else if (opcion == 3)
                    {
                        MostrarDetalleAvion();
                    }
                    else if (opcion == 4)
                    {
                        MostrarDetalleSubmarino();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("debe ingresar un valor valido:");

                }                
            }while (opcion != 0) ;


        }

        public void objetoAvion(int opcion)
        {
            string modelo = "";
            string marca = "";
            float alturaMaxima = 0;
            float alturaMinima = 0;
            Vehiculo tipoAvion = null;

            Console.WriteLine ("Ingrese el modelo:");
            modelo = Console.ReadLine();
            Console.WriteLine ("Ingrese la marca");
            marca = Console.ReadLine();
            Console.WriteLine ("Ingrese altura maxima;");
            string val1 = Console.ReadLine();
            alturaMaxima = Convert.ToInt16(val1);                                           
            Console.WriteLine ("Ingrese altura minima:");
            string val2 = Console.ReadLine();
            alturaMinima = Convert.ToInt16(val2);
         
           tipoAvion  = new Avion (marca, modelo, alturaMaxima, alturaMinima);
           this.DetalleVehiculo.Add(tipoAvion);

        }
        public void objetoSubmanrio(int opcion)
        {            
            string modelo = "";
            string marca = "";
            float profundidadMaxima = 0;       
            
            Vehiculo tipoSubmarino = null;

            Console.WriteLine ("Ingrese el modelo:");
            modelo = Console.ReadLine();
            Console.WriteLine ("Ingrese la marca");
            marca = Console.ReadLine();
            Console.WriteLine ("Ingrese profundidad;");
            string val3 = Console.ReadLine();
            profundidadMaxima = Convert.ToInt16(val3);                                           
           
         
           tipoSubmarino  = new Submarino (marca, modelo, profundidadMaxima);
           this.DetalleVehiculo.Add(tipoSubmarino);
           
        }

        public void MostrarDetalleAvion()  
        {
            foreach (var tipoAvion in DetalleVehiculo)
            {
                Console.WriteLine(tipoAvion);
            }

        }

        public void MostrarDetalleSubmarino()
        {
            foreach (var tipoSubmarino in DetalleVehiculo)
            {
                Console.WriteLine(tipoSubmarino);
            }

        }


    }


}