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
    public class ManageSalle
    {
        public static List<SalleEntity> ListSalles(Expression<Func<SalleEntity, bool>> condition)
        {
            return SalleProvider.List(condition);
        }
        public static bool NewSalle(SalleEntity salle)
        {
            return SalleProvider.Add(salle);
        }
        public static bool DeleteSalle(SalleEntity salle)
        {
            return SalleProvider.Remove(salle);
        }
        public static bool ModifySalle(SalleEntity salle)
        {
            return SalleProvider.Modify(salle);
        }
    }
}
