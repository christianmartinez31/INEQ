using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class EquipmentTypeDal
    {
        /// <summary>
        /// este metodo sirve para cosnultar todos los registros de la tabla Equimentype
        /// </summary>
        private static Ineq1Entities db = new Ineq1Entities();
        public static List<EquipmentType> getAll()
        {
            return db.EquipmentTypes.ToList();
        }
        /// <summary>
        /// este metodo sire pra consultar los registros filtrados la descripcion
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public static List<EquipmentType> getByDescription(string description)
        {
            return db.EquipmentTypes.Where(e => e.Description == description).ToList();
        }
        /// <summary>
        /// objeto equiment type
        /// </summary>
        /// <param name="et"></param>
        /// <returns></returns>
        public static bool addEquimentType(EquipmentType et)
        {
            db.EquipmentTypes.Add(et);
            return db.SaveChanges() > 0;
        }
        /// <summary>
        /// sirve para actualizar un registro equiment type
        /// </summary>
        /// <param name="et"></param>
        /// <returns></returns>
        public static bool updateEquimentType(EquipmentType et)
        {
            db.EquipmentTypes.Attach(et);
            db.Entry(et).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() > 0;
        }

    }
}
