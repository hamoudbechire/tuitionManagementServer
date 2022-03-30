using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using System.Linq.Expressions;

namespace BusinessLayer
{
    public class ManageAdmin
    {
        public static List<AdminEntity> ListAdmin(Expression<Func<AdminEntity, bool>> condition)
        {
            return AdminProvider.List(condition);
        }
        public static bool NewAdmin(AdminEntity admin)
        {
            return AdminProvider.Add(admin);
        }
        public static bool DeleteAdmin(AdminEntity admin)
        {
            return AdminProvider.Remove(admin);
        }
        public static bool ModifyAdmin(AdminEntity admin)
        {
            return AdminProvider.Modify(admin);
        }
    }
}
