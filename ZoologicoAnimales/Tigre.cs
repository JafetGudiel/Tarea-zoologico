using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Tigre
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

        public Tigre(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionTigre()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Tigre:");
            Console.WriteLine("El Tigre: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionTigre()
        {
            Console.WriteLine("El Tigre esta cazando una presaaaa!!!");
        }
        public void sonidoTigre()
        {
            Console.WriteLine("El Tigre comienza a rugir Grrrrrrrrr!!");
        }
        public void movimientosTigre()
        {
            Console.WriteLine("El Tigre ataca a la presa!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
