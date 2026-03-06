using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    // =============================
    // CLASE BASE
    // (CÓDIGO DEL INGENIERO)
    // =============================
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

    // =============================
    // PROGRAMA PRINCIPAL
    // =============================
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

            List<Vehiculo> vehiculos = new List<Vehiculo>();


            // TODO: Crear al menos DOS objetos de clases hijas
            // Ejemplo: Carro, Moto

            Carro carro1 = new Carro("Toyota", "Corolla", 2022, 4);
            Carro carro2 = new Carro("Honda", "Civic", 2023, 4);

            Moto moto1 = new Moto("Yamaha", "R3", 2021, 321);
            Moto moto2 = new Moto("Kawasaki", "Ninja 400", 2022, 399);


            // TODO: Agregar los objetos a la lista

            vehiculos.Add(carro1);
            vehiculos.Add(carro2);
            vehiculos.Add(moto1);
            vehiculos.Add(moto2);


            // TODO: Recorrer la lista usando foreach

            foreach (Vehiculo v in vehiculos)
            {

                // TODO: Llamar a los métodos
                // MostrarInformacion()
                // Encender()

                Console.WriteLine("------------------------------------");

                v.MostrarInformacion();
                v.Encender();

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }


    // =============================
    // CLASE HIJA: CARRO
    // HEREDA DE VEHICULO
    // =============================
    public class Carro : Vehiculo
    {
        // Atributo adicional solicitado
        public int NumeroPuertas { get; set; }

        // Constructor
        public Carro(string marca, string modelo, int anio, int numeroPuertas)
            : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        // Sobrescritura del método MostrarInformacion()
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Número de puertas: " + NumeroPuertas);
        }

        // Sobrescritura del método Encender()
        public override void Encender()
        {
            Console.WriteLine("El carro se está encendiendo con sistema electrónico...");
        }
    }


    // =============================
    // CLASE HIJA: MOTO
    // HEREDA DE VEHICULO
    // =============================
    public class Moto : Vehiculo
    {
        // Atributo adicional solicitado
        public int Cilindraje { get; set; }

        // Constructor
        public Moto(string marca, string modelo, int anio, int cilindraje)
            : base(marca, modelo, anio)
        {
            Cilindraje = cilindraje;
        }

        // Sobrescritura del método MostrarInformacion()
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Cilindraje: " + Cilindraje + " cc");
        }

        // Sobrescritura del método Encender()
        public override void Encender()
        {
            Console.WriteLine("La moto se está encendiendo con arranque eléctrico...");
        }
    }
}

}
