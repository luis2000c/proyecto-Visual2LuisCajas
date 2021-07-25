using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Procesos;

namespace Simulacion
{
    public class datosComprasVentas
    {
        public void Generar() {
            /////Ingreso de compras
            ///Compra 1
            string nomProducto = "Logitech Gaming Keyboard";
            comprasProc comProc = new();
            if (comProc.ingresarCompra(nomProducto, 2021, 01, 01, 10))
            {
                Console.WriteLine("Compra ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su compra");
            }
            //Compra 2
            string nomProducto1 = "Impresora Termica de Ticket EPSON TM";
            comprasProc comProc1 = new();
            if (comProc1.ingresarCompra(nomProducto1, 2021, 02, 03, 5))
            {
                Console.WriteLine("Compra ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su compra");
            }
            //Compra 3
            string nomProducto2 = "Laptop Lenovo";
            comprasProc comProc2 = new();
            if (comProc2.ingresarCompra(nomProducto2, 2021, 03, 05, 2))
            {
                Console.WriteLine("Compra ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su compra");
            }
            //Compra 4
            string nomProducto3 = "Sistema de Audio Portable eLasser";
            comprasProc comProc3 = new();
            if (comProc3.ingresarCompra(nomProducto3, 2021, 04, 07, 15))
            {
                Console.WriteLine("Compra ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su compra");
            }
            //Compra 5
            string nomProducto4 = "Proyector Portatil Inalambrico";
            comprasProc comProc4 = new();
            if (comProc4.ingresarCompra(nomProducto4, 2021, 05, 09, 3))
            {
                Console.WriteLine("Compra ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su compra");
            }

            //Compra 6
            string nomProducto5 = "Tablet Hyundai Koral 10XL";
            comprasProc comProc5 = new();
            if (comProc5.ingresarCompra(nomProducto5, 2021, 11, 22, 4))
            {
                Console.WriteLine("Compra ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su compra");
            }

            ///////////////Ingreso de ventas////////////////////////
            //Venta 1
            ventasProc venProc = new();
            if (venProc.ingresarVenta(nomProducto, 2020, 06, 10, 5))
            {
                Console.WriteLine("Venta ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su venta");
            }
            //Venta 2
            ventasProc venProc1 = new();
            if (venProc1.ingresarVenta(nomProducto1, 2020, 07, 12, 3))
            {
                Console.WriteLine("Venta ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su venta");
            }
            //Venta 3
            ventasProc venProc2 = new();
            if (venProc2.ingresarVenta(nomProducto2, 2020, 08, 15, 2))
            {
                Console.WriteLine("Venta ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su venta");
            }

            //Venta 4
            ventasProc venProc3 = new();
            if (venProc3.ingresarVenta(nomProducto3, 2020, 09, 17, 25))
            {
                Console.WriteLine("Venta ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su venta");
            }

            //Venta 5
            ventasProc venProc4 = new();
            if (venProc4.ingresarVenta(nomProducto4, 2020, 10, 20, 2))
            {
                Console.WriteLine("Venta ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su venta");
            }
            //Venta 6
            string nomProducto6 = "Samsung Galaxy A32";
            ventasProc venProc5 = new();
            if (venProc5.ingresarVenta(nomProducto6, 2020, 12, 25, 10))
            {
                Console.WriteLine("Venta ingresada exitosamente");
            }
            else
            {
                Console.WriteLine("No se pudo ingresar su venta");
            }

        }
    }
}
