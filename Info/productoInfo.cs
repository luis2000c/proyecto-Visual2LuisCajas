using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Info
{
    public class productoInfo: IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Producto pro = (Producto)entidad;
            return String.Format("ProductoId: {0} \n" +
                          "Nombre Producto: {1} \n" +
                          "Costo Unitario: {2} \n",
                pro.ProductoId,
                pro.nomProducto,
                pro.costoUnitario
                );
        }

        public string Publicar(IEnumerable<IDBEntity> ListaTipo)
        {
            var cadena = "";

            foreach (var item in ListaTipo)
            {
                cadena += Publicar(item) + "\n";
            }

            return cadena;
        }
    }
}
