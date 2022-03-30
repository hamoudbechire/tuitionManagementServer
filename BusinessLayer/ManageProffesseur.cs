using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using System.Linq.Expressions;
 

namespace BusinessLayer
{
    public class ManageProffesseur
    {

        public static List<ProffesseurEntity> ListProf(Expression<Func<ProffesseurEntity, bool>> condition)
        {
            return ProffesseurProvider.List(condition);
        }


        public static bool NewProf(ProffesseurEntity prof)
        {
            return ProffesseurProvider.Add(prof);
        }

        public static bool DeleteProf(ProffesseurEntity prof)
        {
            return ProffesseurProvider.Remove(prof);
        }

        public static bool ModifyProf(ProffesseurEntity prof)
        {
            return ProffesseurProvider.Modify(prof);
        }
    }
}

