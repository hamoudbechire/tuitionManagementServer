using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.DataProvider;

namespace BusinessLayer
{
    public class ManageEtudiant
    {

        public static bool NewEtudiant(EtudiantEntity etudiant)
        {
            return EtudiantProvider.Add(etudiant);
        }
    }
}
