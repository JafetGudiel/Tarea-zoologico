using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Rinoceronte
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public Rinoceronte(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionRinoceronte()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Rinoceronte:");
            Console.WriteLine("El Rinoceronte: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionRinoceronte()
        {
            Console.WriteLine("El Rinoceronte esta comiendo de un arbusto!!!");
        }
        public void sonidoRinoceronte()
        {
            Console.WriteLine("El Rinoceronte comienza a barritar muy fuerte!!");
        }
        public void movimientosRinoceronte()
        {
            Console.WriteLine("El Rinoceronte comienza una estocada!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}