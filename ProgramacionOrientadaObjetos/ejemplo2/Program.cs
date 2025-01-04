using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos = new Articulo[10];
            
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("ingrese los datos del producto..");
                Console.WriteLine("codigo:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("precio:");
                articulos [x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("marca (1 a 10)");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());

            }
            Venta venta = new Venta();
                Console.WriteLine("ingrese la venta");
                Console.WriteLine("codigo cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente !=0)
            {
                Console.WriteLine("codigo de articulo");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese la venta");
                Console.WriteLine("codigo cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
