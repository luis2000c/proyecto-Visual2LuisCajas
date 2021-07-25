using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Persistencia;

namespace Procesos
{
    public class registroProc
    {
       
        public  bool registroExistente(int anio, int mes, int dia)
        {
            //Proceso para crear registro
            using (var db = new proyectoContext())
            {
          
                Registro nuevoRegistro = new Registro();
                var registroExist = db.registros
                    .ToList();
                if (registroExist.Count() == 0)
                {
                    nuevoRegistro.FechaRegistro = new DateTime(anio, mes, dia);
                    db.registros.Add(nuevoRegistro);
                    db.SaveChanges();
                    return false;
                }
                else
                {
                    foreach (var item in registroExist)
                    {
                        if (item.FechaRegistro.Month != mes)
                        {
                            if (item.FechaRegistro.Day != dia)
                            {
                                try
                                {
                                    nuevoRegistro.FechaRegistro = new DateTime(anio, mes, dia);
                                    db.registros.Add(nuevoRegistro);
                                    db.SaveChanges();
                                    return false;
                                }
                                catch (DbUpdateConcurrencyException exception)
                                {
                                    Exception ex = new Exception("Conficto de concurrencia", exception);
                                    throw ex;
                                }
                                
                                

                            }
                        }
                    }
                    
                }
                return true;
            }
        }

    }
}
