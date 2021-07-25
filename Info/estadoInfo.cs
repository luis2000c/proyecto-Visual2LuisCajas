using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Info
{
    public class estadoInfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Estado est = (Estado)entidad;
            return String.Format("EstadoId: {0} \n" +
                          "Nombre Estado: {1} \n",
                est.Estadoid,
                est.NomEstado
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
