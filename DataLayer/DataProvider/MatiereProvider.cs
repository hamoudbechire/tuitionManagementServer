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
        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ///// <summary>
        ///// Adds a new cartProduct to the database.
        ///// </summary>
        ///// <param name="ayni">The Id property is automatically generated.</param>
        ///// <returns></returns>
        //public static bool Add(MatiereEntity ayni)
        //{
        //    if (ayni == null)
        //        return false;


        //    var result = DatabaseConnection.Add<MatiereEntity>(ayni);
        //    return result;
        //}
        //public static bool IsExist(Expression<Func<MatiereEntity, bool>> condition)
        //{
        //    return DatabaseConnection.IsExist<MatiereEntity>(condition);
        //}



        ///// <summary>
        ///// Modifies a cartProduct in the database.
        ///// </summary>
        ///// <param name="ayni">The Id property cannot be modified.</param>
        ///// <returns></returns>
        //public static bool Modify(MatiereEntity ayni)
        //{
        //    if (ayni == null)
        //        return false;

        //    using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
        //    {

        //        context.Entry<MatiereEntity>(ayni).State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();
        //        return true;
        //    }
        //}

        ///// <summary>
        ///// Removes a cartProduct from the database with the same Id.
        ///// </summary>
        ///// <param name="cartProduct">The Id property selects the cartProduct.</param>
        ///// <returns></returns>
        //public static bool Remove(MatiereEntity ayni)
        //{
        //    if (ayni == null)
        //        return false;
        //    return DatabaseConnection.Remove<MatiereEntity>(c => c.Id == ayni.Id);
        //}
        //public static List<MatiereEntity> List(Expression<Func<MatiereEntity, bool>> condition)
        //{
        //    using (var context = new SchoolManagementApi(DatabaseConnection.ConnectionString))
        //    {
        //        var list = context.AyniEntities.Where(condition).OrderByDescending(c => c.CreationDate).ToList();
        //        return list;
        //    }
        //}
        ///*
        // *  public static List<MatiereEntity> List(Expression<Func<MatiereEntity, bool>> condition)
        // {
        //     using (var context = new SchoolManagementApi(DatabaseConnection.ConnectionString))
        //     {
        //         var list = context.Aynis.Where(condition).OrderByDescending(c => c.CreationDate).ToList();
        //         return list;
        //     }
        // }
        // */

        ///// <summary>
        ///// Lists every record from the Partners table where the condition returns true
        ///// </summary>
        ///// <param name="condition">Condition on the records of the table. Eg. (p => p.Id == record.Id)</param>
        ///// <returns></returns>
        ////public static List<CartCartEntity> List(Expression<Func<CartCartEntity, bool>> condition)
        ////{
        ////    using (var context = new FeedbApiContext(DatabaseConnection.ConnectionString))
        ////    {
        ////        var list = context.Historics.Where(condition).OrderByDescending(c => c.Date).ToList();
        ////        return list;
        ////    }
        ////}
    }
}
