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
            int vehi, cantidad, conting = 0;
            double valor = 0, valxcant = 0, acumpie = 0, acummoto = 0, acumauto = 0, acumcam = 0, acumbugy = 0, acumnauti = 0;
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
                            Console.WriteLine("Ingrese la cantidad de vehículos del tipo");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            valxcant = valor * cantidad;
                            acumpie = acumpie + valxcant;
                        }
                        break;
                    case 2:
                        {
                            valor = 800;
                            Console.WriteLine("Ingrese la cantidad de vehículos del tipo");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            valxcant = valor * cantidad;
                            acummoto = acummoto + valxcant;
                        }
                        break;
                    case 3:
                        {
                            valor = 1000;
                            Console.WriteLine("Ingrese la cantidad de vehículos del tipo");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            valxcant = valor * cantidad;
                            acumauto = acumauto + valxcant;
                        }
                        break;
                    case 4:
                        {
                            valor = 1500;
                            Console.WriteLine("Ingrese la cantidad de vehículos del tipo");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            valxcant = valor * cantidad;
                            acumcam = acumcam + valxcant;
                        }
                        break;
                    case 5:
                        {
                            valor = 5000;
                            Console.WriteLine("Ingrese la cantidad de vehículos del tipo");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            valxcant = valor * cantidad;
                            acumbugy = acumbugy + valxcant;
                        }
                        break;
                    case 6:
                        {
                            valor = 1200;
                            Console.WriteLine("Ingrese la cantidad de vehículos del tipo");
                            cantidad = Convert.ToInt32(Console.ReadLine());
                            valxcant = valor * cantidad;
                            acumnauti = acumnauti + valxcant; 
                        }
                        break;
                    default:
                        {
                            bandera = false;
                        }
                        break;
                }
                conting = conting++;
            }
            while (bandera == true);

            Console.WriteLine("Ingrese el número de días");

        }

        static bool RegistrarAcceso()
        {
            int ticket;
            Console.WriteLine("Ingrese 1 si tiene el ticket, sino ingrese otro número");
            ticket = Convert.ToInt32(Console.ReadLine());
            if (ticket == 1)
            {
                return true;
            }
            else
            {
                return false;
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
        static void MostrarCantidadDeIngresos(int a)
        {
            Console.WriteLine("La cantidad de ingresos es: ", a);
        }

        static void Main(string[] args)
        {
            int opcion;
            int contvehi = 0;

            ImprimirMenu();
            opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion >= 1 && opcion <= 3)
            {
                switch (opcion)
                {
                    case 1:
                        {
                            RegistrarAcceso();
                        }
                        break;
                    case 2:
                        {
                            MostrarCantidadDeIngresos(contvehi);
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
