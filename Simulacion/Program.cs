using System;
using System.Linq;
using Escenarios;
using Info;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Persistencia;
using Procesos;

namespace Simulacion
{
    class Program
    {
        static void Main(string[] args)
        {
            var Escenario = new EscenarioPrincipal();
            var escenarioControl = new EscenarioControl();
            escenarioControl.Grabar(Escenario);

            //Datos de las compras y ventas
            datosComprasVentas datosCV = new();
            datosCV.Generar();



        }
    }
}
