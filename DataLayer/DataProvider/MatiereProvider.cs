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
    public class MatiereProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new cartProduct to the database.
        /// </summary>
        /// <param name="ayni">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(MatiereEntity etudiant)
        {
            if (etudiant == null)
                return false;


            var result = DatabaseConnection.Add<MatiereEntity>(etudiant);
            return result;
        }
        public static bool IsExist(Expression<Func<MatiereEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<MatiereEntity>(condition);
        }



        /// <summary>
        /// Modifies a cartProduct in the database.
        /// </summary>
        /// <param name="etudiant">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(MatiereEntity etudiant)
        {
            if (etudiant == null)
                return false;

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {

                context.Entry<MatiereEntity>(etudiant).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a cartProduct from the database with the same Id.
        /// </summary>
        /// <param name="etudiant">The Id property selects the cartProduct.</param>
        /// <returns></returns>
        public static bool Remove(MatiereEntity etudiant)
        {
            if (etudiant == null)
                return false;
            return DatabaseConnection.Remove<MatiereEntity>(c => c.IdMatiere == etudiant.IdMatiere);
        }
        public static List<MatiereEntity> List(Expression<Func<MatiereEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                //var list = context.matieres.Where(condition).OrderByDescending(c => c.IdMatiere).ToList();
                return null; //s list;
            }
        }
    }
}
