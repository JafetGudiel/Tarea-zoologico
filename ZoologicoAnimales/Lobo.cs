﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Lobo
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Genero { get; set; }

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
