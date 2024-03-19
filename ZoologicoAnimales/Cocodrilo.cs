using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Cocodrilo
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public Cocodrilo(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionCocodrilo()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Cocodrilo:");
            Console.WriteLine("El Cocodrilo: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionCocodrilo()
        {
            Console.WriteLine("El Cocodrilo esta comiendo crustaceos!!!");
        }
        public void sonidoCocodrilo()
        {
            Console.WriteLine("El Tigre comienza a gruñir rrruaggggg!!");
        }
        public void movimientosCocodrilo()
        {
            Console.WriteLine("El Cocodrilo se sumerge en el agua!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
