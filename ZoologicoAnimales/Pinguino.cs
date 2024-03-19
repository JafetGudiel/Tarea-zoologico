using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Pinguino
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public Pinguino(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionPinguino()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Pinguino:");
            Console.WriteLine("El Pinguino: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionPinguino()
        {
            Console.WriteLine("El Pinguino esta comiendo peces!!!");
        }
        public void sonidopinguino()
        {
            Console.WriteLine("El pinguino hace el ruido Kiu Kui!!");
        }
        public void movimientospinguino()
        {
            Console.WriteLine("El Pinguino se desliza en una parte de hielo!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}