using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuestoDeControl
{
    internal class Program
    {
        static double recaudacion;
        static int CantidadDeIngresos;

        static void GenerarTicket()
        {
            int vehi;
            double valor;
            bool bandera = true;
            do
            {
                Console.WriteLine("Ingrese el tipo de vehículo");
                Console.WriteLine("1: No tengo vehículo");
                Console.WriteLine("2: Moto");
                Console.WriteLine("3: Auto");
                Console.WriteLine("4: Camioneta");
                Console.WriteLine("5: Bugy");
                Console.WriteLine("6: Vehículo Náutico");
                Console.WriteLine("Otro para terminar mis ingresos");
                vehi = Convert.ToInt32(Console.ReadLine());
                switch (vehi)
                {
                    case 1:
                        {
                            valor = 100;
                        }
                        break;
                    case 2:
                        {
                            valor = 800;
                        }
                        break;
                    case 3:
                        {
                            valor = 1000;
                        }
                        break;
                    case 4:
                        {
                            valor = 1500;
                        }
                        break;
                    case 5:
                        {
                            valor = 5000;
                        }
                        break;
                    case 6:
                        {
                            valor = 1200;
                        }
                        break;
                    default:
                        {
                            bandera = false;
                        }
                        break;
                }
            } 
            while (bandera == true);

        }

        static void Verificar()
        {
            int ticket;
            int contvehi = 0;
            Console.WriteLine("Ingrese 1 si tiene el ticket, sino ingrese otro número");
            ticket = Convert.ToInt32(Console.ReadLine());
            if (ticket == 1)
            {
                contvehi = contvehi++;
            }
            else
            {
                GenerarTicket();
            }
        }
        static void ImprimirMenu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1: Registrar acceso");
            Console.WriteLine("2: Mostrar cantidad de ingresos");
            Console.WriteLine("3: Mostrar informe de caja");
            Console.WriteLine("Otro para salir");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Ingrese una de las opciones");
            }

        static void Main(string[] args)
        {
            int opcion;

            ImprimirMenu();
            opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion >= 1 && opcion <= 3)
            {
                switch (opcion)
                {
                    case 1:
                        {
                            Verificar();
                        }
                        break;
                    case 2:
                        {
                            MostrarCantidadDeIngresos();
                        }
                        break;
                    case 3:
                        {
                            MostrarInformeCaja();
                        }
                        break;

                }
            }

        }

