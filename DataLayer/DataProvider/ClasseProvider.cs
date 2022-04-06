using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataProvider
{
    public class ClasseProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static bool Add(ClasseEntity classe)
        {
            if (classe == null)
                return false;


            var result = DatabaseConnection.Add<ClasseEntity>(classe);
            return result;
        }

        public static bool Remove(ClasseEntity classe)
        {
            if (classe == null)
                return false;
            return DatabaseConnection.Remove<ClasseEntity>(c => c.Id == classe.Id);
        }


        public static bool Modify(ClasseEntity classe)
        {
            if (classe == null)
                return false;

            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                try
                {
                  
                    context.Entry<ClasseEntity>(classe).State = System.Data.Entity.EntityState.Modified;
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

       
        public static List<ClasseEntity> List(Expression<Func<ClasseEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list = context.Classes.Where(condition).OrderByDescending(c => c.Id).ToList();
                return list;
            }
        }


    }
}
