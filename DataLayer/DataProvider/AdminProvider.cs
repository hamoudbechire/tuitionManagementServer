using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace DataLayer
{
    public class AdminProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new cartProduct to the database.
        /// </summary>
        /// <param name="ayni">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(AdminEntity admin)
        {
            if (admin == null)
                return false;
            var result = DatabaseConnection.Add<AdminEntity>(admin);
            return result;
        }
        public static bool IsExist(Expression<Func<AdminEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<AdminEntity>(condition);
        }

        /// <summary>
        /// Modifies a cartProduct in the database.
        /// </summary>
        /// <param name="etudiant">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(AdminEntity admin)
        {
            if (admin == null)
                return false;

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {

                context.Entry<AdminEntity>(admin).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a cartProduct from the database with the same Id.
        /// </summary>
        /// <param name="etudiant">The Id property selects the cartProduct.</param>
        /// <returns></returns>
        public static bool Remove(AdminEntity admin)
        {
            if (admin == null)
                return false;
            return DatabaseConnection.Remove<AdminEntity>(a => a.Id == admin.Id);
        }
        public static List<AdminEntity> List(Expression<Func<AdminEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list = context.Admins.Where(condition).OrderByDescending(c => c.Id).ToList();
                return list;
            }
        }
    }
}
