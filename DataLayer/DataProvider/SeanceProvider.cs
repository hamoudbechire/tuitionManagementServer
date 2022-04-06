using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SeanceProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new cartProduct to the database.
        /// </summary>
        /// <param name="ayni">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(SeanceEntity seance)
        {
            if (seance == null)
                return false;


            var result = DatabaseConnection.Add<SeanceEntity>(seance);
            return result;
        }
        public static bool IsExist(Expression<Func<SeanceEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<SeanceEntity>(condition);
        }



        /// <summary>
        /// Modifies a cartProduct in the database.
        /// </summary>
        /// <param name="proffesseur">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(SeanceEntity seance)
        {
            if (seance == null)
                return false;

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {

                context.Entry<SeanceEntity>(seance).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a cartProduct from the database with the same Id.
        /// </summary>
        /// <param name="proffesseur">The Id property selects the cartProduct.</param>
        /// <returns></returns>
        public static bool Remove(SeanceEntity seance)
        {
            if (seance == null)
                return false;
            return DatabaseConnection.Remove<SeanceEntity>(s => s.Id == seance.Id);
        }
        public static List<SeanceEntity> List(Expression<Func<SeanceEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list = context.Seances.Include("Classe").Include("Professeur").Include("Matiere").Where(condition).OrderByDescending(c => c.Id).ToList();
                return list;
            }
        }
    }
}
