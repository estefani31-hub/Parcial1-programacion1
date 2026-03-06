using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Vehículo:");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo se está encendiendo...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE VEHICULOS - PARCIAL   ");
            Console.WriteLine("====================================");
            Console.WriteLine();

            // TODO: Crear una lista de tipo Vehiculo
            // Ejemplo: List<Vehiculo> vehiculos = new List<Vehiculo>();


            // TODO: Crear al menos DOS objetos de clases hijas
            // Ejemplo: Carro, Moto


            // TODO: Agregar los objetos a la lista


            // TODO: Recorrer la lista usando foreach


            // TODO: Llamar a los métodos
            // MostrarInformacion()
            // Encender()


            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }
}
