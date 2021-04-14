using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A890222.Actividad02
{
    class Deposito : Producto
    {
        public Deposito()
        {
            
        }

        public List<Producto> Productos = new List<Producto>();

        public void imprimir(List<Producto> lista)
        {
            foreach(Producto producto in lista)
            {
                Console.WriteLine(producto.ToString());
            }
            Console.ReadKey();
        }

        public void pedidoDeProductos(int numeroProducto, int cantidad, List<Producto> lista)
        {
            int contador = 0;
            foreach (Producto producto in lista)
            {
                if (producto.getNumeroDeProducto() == numeroProducto)
                {
                    if (producto.getStock() - cantidad < 0)
                    {
                        Console.WriteLine("No se pudo realizar el pedido, el stock disponible es de " + producto.getStock());
                    }
                    else { 
                        producto.quitarStock(cantidad);
                        Console.WriteLine("El stock se ha actualizado correctamente, presione enter para continuar");
                    }
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No se encontró el número de producto, intente nuevamente, presione enter para continuar");
            }
            
        }

        public void entregaDeProductos(int numeroProducto, int cantidad, List<Producto> lista)
        {
            int contador = 0;
            foreach (Producto producto in lista)
            {
                if (producto.getNumeroDeProducto() == numeroProducto)
                {
                    producto.agregarStock(cantidad);
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No se encontró el número de producto, intente nuevamente, presione enter para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El stock se ha actualizado correctamente, presione enter para continuar");
                Console.ReadKey();
            }
        }

    }

}
