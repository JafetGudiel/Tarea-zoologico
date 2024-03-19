using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Tortuga
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public Tortuga(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionTortuga()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones de la tortuga:");
            Console.WriteLine("La tortuga: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionTortuga()
        {
            Console.WriteLine("La tortuga esta comiendo algas marinas!!!");
        }
        public void sonidoTortuga()
        {
            Console.WriteLine("La tortuga hace kuaaazzz intentando atacar!!");
        }
        public void movimientosTortuga()
        {
            Console.WriteLine("El Tortuga empieza a nadar rapido!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
