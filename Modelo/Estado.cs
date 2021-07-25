using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estado : IDBEntity
    {
        public int Estadoid { get; set; }
        public string NomEstado { get; set; }

        //Relacion con compra y venta
        public List<Compras> Compras { get; set; }
        public List<Ventas> Ventas { get; set; }
    }
}
