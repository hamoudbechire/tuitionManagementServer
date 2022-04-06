using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DataProvider;
using System.Linq.Expressions;

namespace BusinessLayer
{
    public class ManageEtudiant
    {

        public static bool NewEtudiant(EtudiantEntity etudiant)
        {
            return EtudiantProvider.Add(etudiant);
        }

        public static List<EtudiantEntity> ListEtudiant(Expression<Func<EtudiantEntity, bool>> condition)
        {
            return EtudiantProvider.List(condition);
        }

        public static bool UpdateEtudiant(EtudiantEntity etudiant)
        {
            return EtudiantProvider.Modify(etudiant);
        }
        public static bool RemoveEtudiant(EtudiantEntity etudiant)
        {
            return EtudiantProvider.Remove(etudiant);
        }
        
    }
}
