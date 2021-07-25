using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Info
{
    public class comprasInfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Compras com = (Compras)entidad;
            return String.Format("CompraId: {0} \n" +
                          "EstadoId: {1} \n" +
                          "ProductoId: {2} \n" +
                          "Cantidad: {3} \n",
                          "Costo Total: {4} \n",
                com.ComprasId,
                com.EstadoId,
                com.ProductoId,
                com.cantidad,
                com.CostoTotal
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
