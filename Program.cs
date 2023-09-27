using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCamisas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la tienda de camisas");
            Console.Write("Ingrese la cantidad de camisas que desea comprar: ");
            int cantidadCamisas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio por camisa: ");
            double precioPorCamisa = double.Parse(Console.ReadLine());
            double precioTotalSinDescuento = cantidadCamisas * precioPorCamisa;
            double descuento = 0;

            if (cantidadCamisas == 1)
            {
                descuento = 0;
            }
            else if (cantidadCamisas >= 2 && cantidadCamisas <= 5)
            {
                descuento = 0.10 * precioTotalSinDescuento;
            }
            else if (cantidadCamisas > 5)
            {
                descuento = 0.20 * precioTotalSinDescuento;
            }
            double precioTotalConDescuento = precioTotalSinDescuento - descuento;

            Console.WriteLine($"Cantidad de camisas: {cantidadCamisas}");
            Console.WriteLine($"Precio por camisa: ${precioPorCamisa}");
            Console.WriteLine($"Precio total sin descuento: ${precioTotalSinDescuento}");
            Console.WriteLine($"Descuento aplicado: ${descuento}");
            Console.WriteLine($"Precio total con descuento: ${precioTotalConDescuento}");
            Console.WriteLine("¡Gracias por su compra!");
            Console.ReadLine();
        }
    }
}
