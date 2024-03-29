﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class PavoReal
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public PavoReal(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionPavoReal()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del pavo real:");
            Console.WriteLine("El Elefante: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionPavoReal()
        {
            Console.WriteLine("El pavo real esta comiendo semillas !!!");
        }
        public void sonidoPavoReal()
        {
            Console.WriteLine("El pavo real comienza hacer glugluglu!!");
        }
        public void movimientosPavoReal()
        {
            Console.WriteLine("El pavo real extiende sus alas!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
