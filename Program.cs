using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A890222.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposito uno = new Deposito();

            Producto AñadirProducto = new Producto();

            bool menu = true;

            do
            {
                Console.Clear();
                Console.WriteLine(

                    "Menu principal: \n " +
                    "1: Ingresar un producto nuevo \n " +
                    "2: Ingresar entrega de producto\n " +
                    "3: Ingresar pedido de producto \n " +
                    "4: Imprimir listado de productos\n " +
                    "5: Salir del sistema \n ");

                int opcion = -1;

                do
                {
                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        opcion = -1;
                    }
                    if (opcion < 0)
                    {
                        Console.WriteLine("El valor ingresado no es válido, intente nuevamente ingresando una de las opciones");
                    }
                } while (opcion < 0);

                switch (opcion)
                {
                    case 1:
                        AñadirProducto.ingresoDeProductos(uno.Productos);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero del producto que se entregó");
                        int numeroProductoEntrega;
                        int opcion2 = -1;
                        do
                        {
                            if (!int.TryParse(Console.ReadLine(), out opcion2))
                            {
                                opcion2 = -1;
                            }
                            if (opcion2 < 0)
                            {
                                Console.WriteLine("El valor ingresado no es válido, intente nuevamente ingresando un numero entero positivo");
                                Console.ReadKey();
                            }
                        } while (opcion2 < 0);
                        numeroProductoEntrega = opcion2;

                        Console.Clear();
                        Console.WriteLine("Ingrese la cantidad del producto que ingresó");
                        int cantidadProductoEntrega;
                        int opcion5 = -1;
                        do
                        {
                            if (!int.TryParse(Console.ReadLine(), out opcion5))
                            {
                                opcion5 = -1;
                            }
                            if (opcion5 < 0)
                            {
                                Console.WriteLine("El valor ingresado no es válido, intente nuevamente ingresando un numero entero positivo");
                                Console.ReadKey();
                            }
                        } while (opcion5 < 0);
                        cantidadProductoEntrega = opcion5;

                        uno.entregaDeProductos(numeroProductoEntrega,cantidadProductoEntrega,uno.Productos);

                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese el numero del producto que ingresó");
                        int numeroProducto;
                        int opcion3 = -1;
                        do
                        {
                            if (!int.TryParse(Console.ReadLine(), out opcion3))
                            {
                                opcion3 = -1;
                            }
                            if (opcion3 < 0)
                            {
                                Console.WriteLine("El valor ingresado no es válido, intente nuevamente ingresando un numero entero positivo");
                                Console.ReadKey();
                            }
                        } while (opcion3 < 0);
                        numeroProducto = opcion3;

                        Console.Clear();
                        Console.WriteLine("Ingrese la cantidad del producto que ingresó");
                        int cantidadProducto;
                        int opcion4 = -1;
                        do
                        {
                            if (!int.TryParse(Console.ReadLine(), out opcion4))
                            {
                                opcion4 = -1;
                            }
                            if (opcion4 < 0)
                            {
                                Console.WriteLine("El valor ingresado no es válido, intente nuevamente ingresando un numero entero positivo");
                                Console.ReadKey();
                            }
                        } while (opcion4 < 0);
                        cantidadProducto = opcion4;

                        uno.pedidoDeProductos(numeroProducto, cantidadProducto, uno.Productos);

                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        uno.imprimir(uno.Productos);
                        Console.WriteLine("Presione cualquier tecla para volver al menú.");
                        break;

                    case 5:
                        menu = false;
                        uno.imprimir(uno.Productos);
                        Console.WriteLine("Presione cualquier tecla para finalizar");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida, intente nuevamente");
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadKey();
                        break;
                }

            } while (menu);



        }
    }













}
