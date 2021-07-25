using System;
using Escenarios;
using Persistencia;
using Procesos;
using Simulacion;
using Xunit;

namespace PruebasProyecto
{
    public class UnitTest1
    {
        public UnitTest1() {
            EscenarioPrincipal Escenario = new EscenarioPrincipal();
            EscenarioControl escenarioControl = new EscenarioControl();
            escenarioControl.Grabar(Escenario);

            //Datos de las compras y ventas
            datosComprasVentas datosCV = new();
            datosCV.Generar();
        }
        [Theory]
        [InlineData(2021,01,01,false)]
        [InlineData(2021, 02, 03, false)]
        [InlineData(2021, 03, 05, false)]
        [InlineData(2021, 04, 07, false)]
        [InlineData(2021, 05, 09, false)]
        [InlineData(2021, 11, 22, false)]
        [InlineData(2021, 06, 10, false)]
        [InlineData(2021, 07, 12, false)]
        [InlineData(2021, 08, 15, false)]
        [InlineData(2021, 09, 17, false)]
        [InlineData(2021, 10, 20, false)]
        [InlineData(2021, 12, 25, false)]
        public void Test1(int anio, int mes, int dia,bool valorEsperado)
        {   //Preparacion
            registroProc reg = new();
            //Ejecucion
            var respuesta = reg.registroExistente(anio, mes, dia);
            //Verificacion
            if (valorEsperado)
            {
                Assert.True(respuesta);
            }
            else
            {
                Assert.False(respuesta);
            }
        }

        [Theory]
        [InlineData(1, "Logitech Gaming Keyboard", true)]
        [InlineData(2, "Impresora Termica de Ticket EPSON TM", true)]
        [InlineData(3, "Laptop Lenovo", true)]
        [InlineData(4, "Sistema de Audio Portable eLasser", true)]
        [InlineData(5, "Proyector Portatil Inalambrico", true)]
        [InlineData(6, "Tablet Hyundai Koral 10XL", true)]
        public void TestCompras(int compraID, string nomProc, bool valorEsperado)
        {
            bool respuesta;
            using (var db = new proyectoContext())
            {
                //Preparación
                comprasProc comProc = new();
                //Ejecucion
                respuesta = comProc.existenciaCompras(compraID);

            }


            //Verificacion
            if (valorEsperado)
            {
                Assert.True(respuesta, nomProc + " existe");
            }
            else
            {
                Assert.False(respuesta, nomProc + " no existe");
            }
        }
    }
}
