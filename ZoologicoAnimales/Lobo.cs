using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Lobo
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public Lobo(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionLobo()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Lobo:");
            Console.WriteLine("El Lobo: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionLobo()
        {
            Console.WriteLine("El Esta comiendo Carne de una presa!!!");
        }
        public void sonidoLobo()
        {
            Console.WriteLine("El Tigre comienza a decir Auuuuuuuuuuu!!");
        }
        public void movimientosLobo()
        {
            Console.WriteLine("El Lobo corre a buscar su manada!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
