using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A890222.Actividad02
{
    class Producto
    {
        public Producto()
        {

        }

        public override string ToString()
        {
            return "Numero del producto: " + this.numeroDeProducto + "\nNombre del producto: " + this.nombreDeProducto + "\nStock del producto: " + this.stock + "\n";
        }

        public Producto(int numeroProducto, int stockInicial, String nombreProducto)
        {
            this.nombreDeProducto = nombreProducto;
            this.numeroDeProducto = numeroProducto;
            this.stock = stockInicial;
        }

        private String nombreDeProducto;
        private int numeroDeProducto;
        private int stock;

        public int getNumeroDeProducto()
        {
            return this.numeroDeProducto;
        }

        public int getStock()
        {
            return this.stock;
        }

        public void agregarStock(int entrada)
        {
            this.stock = this.stock + entrada;
        }
        
        public void quitarStock(int salida)
        {
            this.stock = this.stock - salida;
        }

        public void ingresoDeProductos(List<Producto> lista)
        {
            Producto nuevo = new Producto();

            int nombre = 0;
            do
            {
                nombre = 0;
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del nuevo producto, luego presione enter para continuar");
                nuevo.nombreDeProducto = Console.ReadLine();

                foreach (Producto producto in lista)
                {
                    if (producto.nombreDeProducto.ToUpper() == nuevo.nombreDeProducto.ToUpper())
                    {
                        nombre++;
                    }
                }

                if (nombre > 0)
                {
                    Console.WriteLine("Ya existe un producto con ese nombre, presione enter y luego intente nuevamente con otro nombre");
                    Console.ReadKey();
                }

            } while (nombre > 0);
            
            int numero = 0;
            do
            {
                numero = 0;
                Console.Clear();
                Console.WriteLine("Ingrese el número del nuevo producto, luego presione enter para continuar");

                int opcion = -1;
                do
                {
                    opcion = -1;
                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        opcion = -1;
                    }
                    if (opcion < 0)
                    {
                        Console.WriteLine("El valor ingresado no es válido, intente nuevamente ingresando un numero entero positivo");
                        Console.ReadKey();
                    }
                } while (opcion < 0);
                nuevo.numeroDeProducto = opcion;


                foreach (Producto producto in lista)
                {
                    if (producto.numeroDeProducto == nuevo.numeroDeProducto)
                    {
                        numero++;
                    }
                }

                if (numero > 0)
                {
                    Console.WriteLine("Ya existe un producto con ese número de producto, intente nuevamente");
                    Console.ReadKey();
                }

            } while (numero > 0);

            Console.Clear();
            Console.WriteLine("Ingrese el stock inicial del producto");

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
                }
            } while (opcion2 < 0);
            nuevo.stock = opcion2;

            lista.Add(nuevo);
            Console.Clear();
            Console.WriteLine("El producto " + nuevo.nombreDeProducto + " fue agregado exitosamente, presione enter para continuar");
            
        }

        


        

    }

}
