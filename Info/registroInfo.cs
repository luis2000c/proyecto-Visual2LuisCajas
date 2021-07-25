using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Info
{
    public class registroInfo : IEntityInfo
    {
        public string Publicar(IDBEntity entidad)
        {
            Registro reg = (Registro)entidad;
            return String.Format("RegistroId: {0} \n" +
                          "FechaRegistro: {1} \n",

                reg.RegistroId,
                reg.FechaRegistro
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
