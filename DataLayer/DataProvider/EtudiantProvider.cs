using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataProvider
{
    public class EtudiantProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static bool Add(EtudiantEntity etudiant)
        {
            if (etudiant == null)
                return false;

          //  using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
           // {
             //   var obj = (from classe in context.Classes where classe.Id==id select classe).FirstOrDefault();
            //    obj.etudiants.Add(etudiant);
                
           // }
            var result = DatabaseConnection.Add<EtudiantEntity>(etudiant);
            return result;
        }

        public static bool Remove(EtudiantEntity etudiant)
        {
            if (etudiant == null)
                return false;
            return DatabaseConnection.Remove<EtudiantEntity>(c => c.Id == etudiant.Id);
        }


        public static bool Modify(EtudiantEntity etudiant)
        {
            if (etudiant == null)
                return false;

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                try
                {

                    context.Entry<EtudiantEntity>(etudiant).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    log.Error(string.Format("Error Modify {0} Provider \n :", "UserFavoriteProduct"), ex);
                    return false;
                }
            }
        }
        public static List<EtudiantEntity> List(Expression<Func<EtudiantEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list = context.Etudiants.Where(condition).OrderByDescending(c => c.Id).ToList();
                return list;
            }
        }

      
        
    }
}
