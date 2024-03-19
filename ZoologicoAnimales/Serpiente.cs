using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Serpiente
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public Serpiente(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionSerpiente()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones de la serpiente:");
            Console.WriteLine("La serpiente: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionSerpiente()
        {
            Console.WriteLine("El Serpiente esta deborando un roedor!!!");
        }
        public void sonidoSerpiente()
        {
            Console.WriteLine("La serpiente comienza a comienza a hacer ZZZZZZZ!!");
        }
        public void movimientosSerpiente()
        {
            Console.WriteLine("La serpiente se esconde entre los arbustos!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}