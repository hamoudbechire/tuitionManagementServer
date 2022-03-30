using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataLayer
{
    public class SalleProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new cartProduct to the database.
        /// </summary>
        /// <param name="ayni">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(SalleEntity s)
        {
            if (s == null)
                return false;
            var result = DatabaseConnection.Add<SalleEntity>(s);
            return result;
        }
        public static bool IsExist(Expression<Func<SalleEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<SalleEntity>(condition);
        }

        /// <summary>
        /// Modifies a cartProduct in the database.
        /// </summary>
        /// <param name="etudiant">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(SalleEntity s)
        {
            if (s == null)
                return false;

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {

                context.Entry<SalleEntity>(s).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a cartProduct from the database with the same Id.
        /// </summary>
        /// <param name="etudiant">The Id property selects the cartProduct.</param>
        /// <returns></returns>
        public static bool Remove(SalleEntity s)
        {
            if (s == null)
                return false;
            return DatabaseConnection.Remove<SalleEntity>(salle => salle.Id == s.Id);
        }
        public static List<SalleEntity> List(Expression<Func<SalleEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list = context.Salles.Where(condition).OrderByDescending(s => s.Id).ToList();
                return list;
            }
        }
    }
}
