using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Compras : IDBEntity
    {
        public int ComprasId { get; set; }
        //Relacion con estado
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
        public int cantidad { get; set; }

        public float CostoTotal { get; set; }

        //Relacion con Producto
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        //Relacion con registro
        public int RegistroId { get; set; }
        public Registro Registro { get; set; }
    }
}
