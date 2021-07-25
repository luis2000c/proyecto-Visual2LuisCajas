using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Info
{
    public class ventasInfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Ventas ven = (Ventas)entidad;
            return String.Format("VentaId: {0} \n" +
                          "EstadoId: {1} \n" +
                          "ProductoId: {2} \n" +
                          "Cantidad: {3} \n",
                          "Costo Total: {4} \n",
                ven.VentasId,
                ven.EstadoId,
                ven.ProductoId,
                ven.cantidad,
                ven.CostoTotal
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
