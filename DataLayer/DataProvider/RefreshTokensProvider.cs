using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Linq.Expressions;

using EntityLayer;

namespace DataLayer
{
    public class RefreshTokensProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new refreshToken to the database.
        /// </summary>
        /// <param name="refreshToken">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(RefreshTokenEntity refreshToken)
        {
            if (refreshToken == null)
                return false;
            var result = DatabaseConnection.Add<RefreshTokenEntity>(refreshToken);
            return result;
        }
        public static bool IsExist(Expression<Func<RefreshTokenEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<RefreshTokenEntity>(condition);
        }



        /// <summary>
        /// Modifies a refreshToken in the database.
        /// </summary>
        /// <param name="refreshToken">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(RefreshTokenEntity refreshToken)
        {
            if (refreshToken == null)
                return false;
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                context.Entry<RefreshTokenEntity>(refreshToken).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a refreshToken from the database with the same Id.
        /// </summary>
        /// <param name="refreshToken">The Id property selects the refreshToken.</param>
        /// <returns></returns>
        public static bool Remove(RefreshTokenEntity refreshToken)
        {
            if (refreshToken == null)
                return false;
            return DatabaseConnection.Remove<RefreshTokenEntity>(c => c.Id == refreshToken.Id);
        }

        /// <summary>
        /// Lists every record from the Partners table where the condition returns true
        /// </summary>
        /// <param name="condition">Condition on the records of the table. Eg. (p => p.Id == record.Id)</param>
        /// <returns></returns>
        public static List<RefreshTokenEntity> List(Expression<Func<RefreshTokenEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list = context.RefreshTokens
                    .Where(condition).OrderByDescending(c => c.ExpiresUtc).ToList();
                return list;
            }
        }

    }
}
