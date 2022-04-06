using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ManageSeances
    {
        public static List<SeanceEntity> ListSeances(Expression<Func<SeanceEntity, bool>> condition)
        {
            return SeanceProvider.List(condition);
        }

        public static bool NewSeance(SeanceEntity seance)
        {
            return SeanceProvider.Add(seance);
        }

        public static bool DeleteSeance(SeanceEntity seance)
        {
            return SeanceProvider.Remove(seance);
        }

        public static bool ModifySeance(SeanceEntity seance)
        {
            return SeanceProvider.Modify(seance);
        }
    }
}
