using System;
using System.Collections.Generic;

namespace ParcialProgramacion1G2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TODO: Crear una lista de tipo Vehiculo
            // Ejemplo: List<Vehiculo> vehiculos = new List<Vehiculo>();

            List<Vehiculo> vehiculos = new List<Vehiculo>();


            // TODO: Crear al menos DOS objetos de clases hijas
            // Ejemplo: Carro, Moto

            Carro carro1 = new Carro("Toyota", "Corolla", 2020);
            Moto moto1 = new Moto("Yamaha", "R3", 2021);


            // TODO: Agregar los objetos a la lista

            vehiculos.Add(carro1);
            vehiculos.Add(moto1);


            // TODO: Recorrer la lista usando foreach

            foreach (Vehiculo v in vehiculos)
            {

                // TODO: Llamar a los métodos
                // MostrarInformacion()
                // Encender()

                v.MostrarInformacion();
                v.Encender();

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
        }
    }
}
