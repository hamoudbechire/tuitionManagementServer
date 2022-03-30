using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
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

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                //var list_classe = context.classes.ToList();
                
            }
            var result = DatabaseConnection.Add<EtudiantEntity>(etudiant);
            return result;
        }

        public static bool Remove(EtudiantEntity etudiant)
        {
            if (etudiant == null)
                return false;
            return DatabaseConnection.Remove<EtudiantEntity>(c => c.EtudiantId == etudiant.EtudiantId);
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


        public static List<EtudiantEntity> List()
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list_étudiant = context.Etudiants.Include("classe").ToList();
                return list_étudiant;
            }
        }
        
    }
}
