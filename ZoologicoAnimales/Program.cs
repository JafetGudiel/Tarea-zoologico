using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoologicoAnimales
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
           bool abandonar = false;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("BIENVENIDOS AL PROGRAMA DEL ZOOLOGICO");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Ingrese el numero de la accion que desee realizar");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Visitar Leon");
                Console.WriteLine("2. Visitar Elefante");
                Console.WriteLine("3. Visitar Jirafa");
                Console.WriteLine("4. Visitar Tigre");
                Console.WriteLine("5. Visitar Mono");
                Console.WriteLine("6. Visitar oso");
                Console.WriteLine("7. Visitar Cocodrilo");
                Console.WriteLine("8. Visitar Serpiente");
                Console.WriteLine("9. Visitar Pinguino");
                Console.WriteLine("10. Visitar Lobo");
                Console.WriteLine("11. Visitar Cebra");
                Console.WriteLine("12. Visitar Rinoceronte");
                Console.WriteLine("13. Visitar Panda");
                Console.WriteLine("14. Visitar Pavoreal");
                Console.WriteLine("15. Visitar Tortuga");
                int ingresoUsuario = int.Parse(Console.ReadLine());

                switch (ingresoUsuario)
                {
                    case 0: abandonar = true; break; 
                    case 1:
                        Leon leon = new Leon("Arturito", 7.88, 2.11, "Masculino");
                        leon.informacionLeon();
                        leon.alimentacionLeon();
                        leon.sonidoLeon();
                        leon.movimientosLeon();
                        break;
                    case 2:
                        Elefante elefante = new Elefante("Rut", 92, 4.12, "Femenino");
                        elefante.informacionElefante();
                        elefante.alimentacionElefante();
                        elefante.sonidoElefante();
                        elefante.movimientosElefante();
                        break;
                    case 3:
                        Jirafa jirafa = new Jirafa("Oscar", 200, 3.4, "Masculino");
                        jirafa.informacionJirafa();
                        jirafa.alimentacionJirafa();
                        jirafa.sonidoJirafa();
                        jirafa.movimientosJirafa();
                        break;
                    case 4:
                        Tigre tigre = new Tigre("Tito", 350, 1.40, "Masculino");
                        tigre.informacionTigre();
                        tigre.alimentacionTigre();
                        tigre.sonidoTigre();
                        tigre.movimientosTigre();
                        break;
                    case 5:
                        Mono mono = new Mono("Jorge el curioso", 0.70, 0.35, "Masculino");
                        mono.informacionMono();
                        mono.alimentacionMono();
                        mono.sonidoMono();
                        mono.movimientosMono();
                        break;
                    case 6:
                        Oso oso = new Oso("Alberto", 400, 1.60, "Masculino");
                        oso.informacionOso();
                        oso.alimentacionOso();
                        oso.sonidoOso();
                        oso.movimientosOso();
                        break;
                    case 7:
                        Cocodrilo cocodrilo = new Cocodrilo("Texter", 250, 0.30, "Masculino");
                        cocodrilo.informacionCocodrilo();
                        cocodrilo.alimentacionCocodrilo();
                        cocodrilo.sonidoCocodrilo();
                        cocodrilo.movimientosCocodrilo();
                        break;
                    case 8:
                        Serpiente serpiente = new Serpiente("Zizuz", 40, 0.20, "Femenino");
                        serpiente.informacionSerpiente();
                        serpiente.alimentacionSerpiente();
                        serpiente.sonidoSerpiente();
                        serpiente.movimientosSerpiente();
                        break;
                    case 9:
                        Pinguino pinguino = new Pinguino("Luis", 50, 0.40, "Masculino");
                        pinguino.informacionPinguino();
                        pinguino.alimentacionPinguino();
                        pinguino.sonidopinguino();
                        pinguino.movimientospinguino();
                        break;
                    case 10:
                        Lobo lobo = new Lobo("Raul", 120, 0.45, "Masculino");
                        lobo.informacionLobo();
                        lobo.alimentacionLobo();
                        lobo.sonidoLobo();
                        lobo.movimientosLobo();
                        break;
                    case 11:
                        Cebra cebra = new Cebra("Celina", 200, 0.60, "Femenino");
                        cebra.informacionCebra();
                        cebra.alimentacionCebra();
                        cebra.sonidoCebra();
                        cebra.movimientosCebra();
                        break;
                    case 12:
                        Rinoceronte rinoceronte = new Rinoceronte("Paul", 700, 1.80, "Maculino");
                        rinoceronte.informacionRinoceronte();
                        rinoceronte.alimentacionRinoceronte();
                        rinoceronte.sonidoRinoceronte();
                        rinoceronte.movimientosRinoceronte();
                        break;
                    case 13:
                        Panda panda = new Panda("plex", 110, 0.40, "Masculino");
                        panda.informacionPanda();
                        panda.alimentacionPanda();
                        panda.sonidoPanda();
                        panda.movimientosPanda();
                        break;
                    case 14:
                        PavoReal pavoreal = new PavoReal("Paco", 20, 0.15, "Masculino");
                        pavoreal.informacionPavoReal();
                        pavoreal.alimentacionPavoReal();
                        pavoreal.sonidoPavoReal();
                        pavoreal.movimientosPavoReal();
                        break;
                    case 15:
                        Tortuga tortuga = new Tortuga("Rafael", 10, 0.10, "Masculino");
                        tortuga.informacionTortuga();
                        tortuga.alimentacionTortuga();
                        tortuga.sonidoTortuga();
                        tortuga.movimientosTortuga();
                        break;
                    default: break;
                }
                Console.WriteLine("Pulse enter para visitar a otro animal o el numero 0 para salir");
                Console.ReadLine();
                Console.Clear();
                

            } while (!abandonar);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("GRACIAS POR UTILIZAR EL PROGRAMA :) ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.ReadLine();


        }
    }
}
