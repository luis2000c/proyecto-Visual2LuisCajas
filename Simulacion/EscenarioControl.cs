using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escenarios;
using Modelo;
using Persistencia;
using static Escenarios.Escenario;

namespace Simulacion
{
    public class EscenarioControl
    {
        public void Grabar(IEscenarios escenario)
        {
            var datos = escenario.carga();
            using (var db = new proyectoContext())
            {

               //Reiniciamos la Base de datos
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                //Insertamos los datos
                db.productos.AddRange((List<Producto>)datos[ListaTipo.Producto]);
                db.estados.AddRange((List<Estado>)datos[ListaTipo.Estados]);
                
                //Genera la persistencia
                db.SaveChanges();

            }
        }
    }
}
