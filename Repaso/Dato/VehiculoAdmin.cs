using Repaso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repaso.Dato
{
    public class VehiculoAdmin
    {
        public IEnumerable<Vehiculos> Consultar()
        {
            using (RepasodbEntities contexto = new RepasodbEntities())
            {
                return contexto.Vehiculos.AsNoTracking().ToList();
            }
        } 

        /// <summary>
        /// Guarda un vehiculo en la base de datos
        /// </summary>
        /// <param name="modelo"></param>
        public void Guardar(Vehiculos modelo)
        {
            using (RepasodbEntities contexto = new RepasodbEntities())
            {
                contexto.Vehiculos.Add(modelo);
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Obtiene vehiculo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Vehiculos Consultar(int id)
        {
            using (RepasodbEntities contexto = new RepasodbEntities())
            {
                return contexto.Vehiculos.FirstOrDefault(v => v.Id == id);
            }
        }

        /// <summary>
        /// Modifica los datos del vehiculo
        /// </summary>
        /// <param name="modelo"></param>
        public void Modificar(Vehiculos modelo)
        {
            using (RepasodbEntities contexto = new RepasodbEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        /// <summary>
        /// Elimina un vehiculo
        /// </summary>
        /// <param name="modelo"></param>
        public void Eliminar(Vehiculos modelo)
        {
            using (RepasodbEntities contexto = new RepasodbEntities())
            {
                contexto.Entry(modelo).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}