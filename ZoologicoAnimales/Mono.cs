﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Mono
    {
        private string Nombre { get; set; }
        private double Peso { get; set; }
        private double Altura { get; set; }
        private string Genero { get; set; }

        public Mono(string nombre, double peso, double altura, string genero)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Genero = genero;
        }

        public void informacionMono()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("Datos y especificaciones del Mono:");
            Console.WriteLine("El Mono: {0}, que pesa: {1}, su altura es de: {2} y su genero es: {3} ", Nombre, Peso, Altura, Genero);
        }

        public void alimentacionMono()
        {
            Console.WriteLine("El Mono Esta comiendo platanos!!!!!");
        }
        public void sonidoMono()
        {
            Console.WriteLine("El Tigre comienza a cantar uh uh ah ah!!!!");
        }
        public void movimientosMono()
        {
            Console.WriteLine("El Mono comienza a saltar en las lianas!!");

            Console.WriteLine("\n-------------------------------------------------------------------------------------------------------------");
        }
    }
}
