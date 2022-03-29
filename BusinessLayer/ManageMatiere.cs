using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using EntityLayer.TableEntity;
using System.Linq.Expressions;

namespace BusinessLayer
{
    public class ManageMatiere
    {

        public static List<MatiereEntity> ListMatiere(Expression<Func<MatiereEntity, bool>> condition)
        {
            return MatiereProvider.List(condition);
        }


        public static bool NewMatiere(MatiereEntity matiere)
        {
            return MatiereProvider.Add(matiere);
        }

        public static bool DeleteMatiere(MatiereEntity matiere)
        {
            return MatiereProvider.Remove(matiere);
        }

        public static bool ModifyMatiere(MatiereEntity matiere)
        {

            return MatiereProvider.Modify(matiere);
        }
    }
}
