using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto : IDBEntity
    {
        public int ProductoId { get; set; }
        public string nomProducto { get; set; }

        public float costoUnitario { get; set; }
        //Relacion Ventas
        public List<Ventas> Ventas { get; set; }
        //Relacion Compras
        public List<Compras> Compras { get; set; }
    }
}
