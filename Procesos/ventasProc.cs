using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Persistencia;

namespace Procesos
{
    public class ventasProc
    {
        public bool ingresarVenta(string nomProducto, int anio, int mes, int dia, int cantidadC)
        {
            using (var db = new proyectoContext())
            {
                ////////////////Producto

                var producto = db.productos
                .Where(pro => pro.nomProducto == nomProducto)
                .Single();
                Console.WriteLine(new productoInfo().Publicar(producto));

                ///////////////////Estados
                ///Regla de negocio
                ////Si el costo de un producto supera los 100 dolares se mantendra un estado
                ///pendiente, caso contrario se pagara sin problemas
                string nomEstado;
                if (producto.costoUnitario > 100)
                {
                    nomEstado = "pendiente";
                }
                else
                {
                    nomEstado = "pagado";
                }
                var estado = db.estados
                    .Where(est => est.NomEstado == nomEstado)
                    .Single();
                Console.WriteLine(new estadoInfo().Publicar(estado));
                //////////Crear Registro
                //Creacion de un nuevo registro
                registroProc reg = new registroProc();
                if (reg.registroExistente(anio, mes, dia))
                {
                    Console.WriteLine("El registro ya existe");

                    Console.WriteLine("Lo sentimos la compra no se pudo ingresar");
                }
                else
                {
                    Console.WriteLine("Registro Creado");
                    /////////////////////////////////////
                    var registroProc = db.registros
                    .Where(reg => reg.FechaRegistro.Month == mes)
                    .Single();
                    Console.WriteLine(new registroInfo().Publicar(registroProc));
                    ///////////////////////////////////////////
                    ///////////////////////////////////////////Registro de ventas

                    Ventas venta = new()
                    {
                        Estado = estado,
                        cantidad = cantidadC,
                        CostoTotal = cantidadC * (producto.costoUnitario),
                        Producto = producto,
                        Registro = registroProc

                    };
                    try
                    {
                        db.ventas.Add(venta);
                        db.SaveChanges();
                        return true;
                    }
                    catch (DbUpdateConcurrencyException exception)
                    {
                        Exception ex = new Exception("Conficto de concurrencia", exception);
                        throw ex;
                    }
                    

                    /////////////////////////////////////
                }
                return false;

            }

        }
    }
}
