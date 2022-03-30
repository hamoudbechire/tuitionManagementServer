using EntityLayer.TableEntity;
using DataLayer.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ManageClasse
    {
        public static bool NewClasse(ClasseEntity classe)
        {
            return ClasseProvider.Add(classe);
        }

        public static bool DeleteProf(ClasseEntity classe)
        {
            return ClasseProvider.Remove(classe);
        }
    }
}
