using BusinessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SchoolManagementApi.Controllers
{
    public class ProffesseurController : ApiController
    {
        //[Authorize]
        //[Route("api/proffesseur")]
        //[AcceptVerbs("GET")]
        // GET: Proffesseur
         
        [AcceptVerbs("GET")]
        public List<ProffesseurEntity> GET()
        {
            var profs = ManageProffesseur.ListProf(obj => true);
            return profs;
        }
        public ProffesseurEntity GET(int id)
        {
            var prof = ManageProffesseur.ListProf(obj => obj.Id == id).FirstOrDefault();
            return prof;
        }
        [AcceptVerbs("POST")]
        public bool POST(ProffesseurEntity prof)
        {
            var result = false;
            if(prof != null) {
                if (prof.Id > 0)
                {
                    result = ManageProffesseur.ModifyProf(prof);
                }
                else
                {
                    result = ManageProffesseur.NewProf(prof);
                }
            } 
                
            return result;
        }
    }
}