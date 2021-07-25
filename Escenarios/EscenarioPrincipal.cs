using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Escenarios
{
    public class EscenarioPrincipal : Escenario, IEscenarios
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> carga()
        {
            //Creacion del producto
            Producto tecladoLogitec = new(){nomProducto = "Logitech Gaming Keyboard",costoUnitario = 60f};
            Producto impresoraTermica = new() { nomProducto = "Impresora Termica de Ticket EPSON TM", costoUnitario = 150.45f };
            Producto laptopLenovo = new() { nomProducto = "Laptop Lenovo", costoUnitario = 250.35f };
            Producto auricularesDeportivos = new() { nomProducto = "Auriculares deportivos con micrófono", costoUnitario = 21f };
            Producto proyectorInalambrico = new() { nomProducto = "Proyector Portatil Inalambrico", costoUnitario = 350.45f };
            Producto samsungA32= new() { nomProducto = "Samsung Galaxy A32", costoUnitario = 85.25f };
            Producto tabletHyundai = new() { nomProducto = "Tablet Hyundai Koral 10XL", costoUnitario = 125.25f };
            Producto audioPortable = new() { nomProducto = "Sistema de Audio Portable eLasser", costoUnitario = 40f };
            Producto laptopGamingHP = new() { nomProducto = "Laptop HP Gaming Intel I5", costoUnitario = 323.15f };
            Producto amazonDot = new() { nomProducto = "Amazon Echo Dot", costoUnitario = 123.20f };
            List<Producto> lstProducto = new()
            {
                tecladoLogitec,impresoraTermica,laptopLenovo,audioPortable,
                proyectorInalambrico,samsungA32,tabletHyundai,
                audioPortable,laptopGamingHP,amazonDot
            };
            datos.Add(ListaTipo.Producto, lstProducto);


            //Creacion de estados
            Estado Pendiente = new Estado()
            {
                NomEstado = "pendiente"
            };
            Estado Pagado = new Estado()
            {
                NomEstado="pagado"
            };
            List<Estado> lstEstado = new()
            {
                Pendiente, Pagado
            };
            datos.Add(ListaTipo.Estados, lstEstado);
            return datos;
        }

     
    }
}
