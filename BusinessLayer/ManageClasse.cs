using EntityLayer.TableEntity;
using DataLayer.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace BusinessLayer
{
    public class ManageClasse
    {
        public static bool NewClasse(ClasseEntity classe)
        {
            return ClasseProvider.Add(classe);
        }

        public static bool RemoveClasse(ClasseEntity classe)
        {
            return ClasseProvider.Remove(classe);
        }

        public static List<ClasseEntity> ListClasse(Expression<Func<ClasseEntity, bool>> condition)
        {
            return ClasseProvider.List(condition);
        }

        public static bool UpdateClasse(ClasseEntity classe)
        {
            return ClasseProvider.Modify(classe);
        }
    }
}
