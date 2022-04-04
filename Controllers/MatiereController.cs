using BusinessLayer;
using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;

namespace SchoolManagementApi.Controllers
{
    [Authorize]
    public class MatiereController : ApiController
    {
        // GET: All Matiere
        public List<MatiereEntity> Get()
        {
            return ManageMatiere.ListMatiere(obj => true);
        }
        // GET: Matiere by id
        public MatiereEntity Get(int id)
        {
            return ManageMatiere.ListMatiere(obj => obj.Id == id).FirstOrDefault();
        }
        // Post Matiere
        public bool Post(MatiereEntity matiere)
        {
            var result = false;
            if(matiere != null)
            {
                if (matiere.Id > 0)
                {
                    result = ManageMatiere.ModifyMatiere(matiere);
                    var prof = ManageProffesseur.ListProf(obj => obj.MatiereId == matiere.Id).FirstOrDefault();
                    if (prof != null)
                    {
                        //prof.Matiere = null;
                        //ManageProffesseur.ModifyProf(prof);
                    }
                    //foreach(var prof in profs)
                    //{
                    //    if (prof != null)
                    //    {
                    //        ManageProffesseur.ModifyProf(prof);
                    //    }
                    //}
                }
                else
                {
                    result = ManageMatiere.NewMatiere(matiere);
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        // Delete Matiere By Id
        [AcceptVerbs("DELETE")]
        public bool Delete(int id)
        {
            var result = false;
            var matiere = Get(id);

            if(matiere != null)
            {
                result = ManageMatiere.DeleteMatiere(matiere);
            }
            return result;
        }
    }
}