using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using EntityLayer;

namespace DataLayer
{
    public class ClientProvider
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Adds a new client to the database.
        /// </summary>
        /// <param name="client">The Id property is automatically generated.</param>
        /// <returns></returns>
        public static bool Add(ClientEntity client)
        {
            if (client == null)
                return false;
            var result = DatabaseConnection.Add<ClientEntity>(client);
            return result;
        }
        public static bool IsExist(Expression<Func<ClientEntity, bool>> condition)
        {
            return DatabaseConnection.IsExist<ClientEntity>(condition);
        }



        /// <summary>
        /// Modifies a client in the database.
        /// </summary>
        /// <param name="client">The Id property cannot be modified.</param>
        /// <returns></returns>
        public static bool Modify(ClientEntity client)
        {
            if (client == null)
                return false;
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                context.Entry<ClientEntity>(client).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Removes a client from the database with the same Id.
        /// </summary>
        /// <param name="client">The Id property selects the client.</param>
        /// <returns></returns>
        public static bool Remove(ClientEntity client)
        {
            if (client == null)
                return false;
            return DatabaseConnection.Remove<ClientEntity>(c => c.Id == client.Id);
        }

        /// <summary>
        /// Lists every record from the Partners table where the condition returns true
        /// </summary>
        /// <param name="condition">Condition on the records of the table. Eg. (p => p.Id == record.Id)</param>
        /// <returns></returns>
        public static List<ClientEntity> List(Expression<Func<ClientEntity, bool>> condition)
        {
            using (var context = new SchoolManagementApiContext(DatabaseConnection.ConnectionString))
            {
                var list = context.Clients.Where(condition).OrderByDescending(c => c.Name).ToList();
                return list;
            }
        }

    }
}
