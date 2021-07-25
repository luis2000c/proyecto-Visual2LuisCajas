using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Registro : IDBEntity
    {
        public int RegistroId {get;set;}
        public DateTime FechaRegistro { get; set; }
       
        public List<Ventas> Ventas { get; set; }
        public List<Compras> Compras { get; set; }

        //public float totalVentas { get; set; }
        //public float totalCompras { get; set; }
    }
}
