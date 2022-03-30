using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using EntityLayer;
 
using System.Linq.Expressions;
using EntityLayer.TableEntity;

namespace DataLayer
{
    public class ProffesseurProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new cartProduct to the database.
        /// </summary>
        /// <param name="ayni">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(ProffesseurEntity proffesseur)
        {
            if (proffesseur == null)
                return false;


            var result = DatabaseConnection.Add<ProffesseurEntity>(proffesseur);
            return result;
        }
        public static bool IsExist(Expression<Func<ProffesseurEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<ProffesseurEntity>(condition);
        }



        /// <summary>
        /// Modifies a cartProduct in the database.
        /// </summary>
        /// <param name="proffesseur">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(ProffesseurEntity proffesseur)
        {
            if (proffesseur == null)
                return false;

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {

                context.Entry<ProffesseurEntity>(proffesseur).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;   
            }
        }

        /// <summary>
        /// Removes a cartProduct from the database with the same Id.
        /// </summary>
        /// <param name="proffesseur">The Id property selects the cartProduct.</param>
        /// <returns></returns>
        public static bool Remove(ProffesseurEntity proffesseur)
        {
            if (proffesseur == null)
                return false;
            return DatabaseConnection.Remove<ProffesseurEntity>(c => c.ProfId == proffesseur.ProfId);
        }
        public static List<ProffesseurEntity> List(Expression<Func<ProffesseurEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
               var list = context.proffesseurs.Where(condition).OrderByDescending(c => c.ProfId).ToList();
                return list;
            }
        }
    }
}
