using BusinessLayer;
using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
 
using System.Net;
using System.Net.Http;
 

namespace SchoolManagementApi.Controllers
{
    //[Authorize]
    
    public class ProffesseurConroller : ApiController
    {
        //public List<ProffesseurEntity> Get()
        //{
        //    var profs = ManageProffesseur.ListProf(obj => true);
        //    return profs;
        //}
        [Route("api/proffesseur")]
        [AcceptVerbs("GET")]
        public string Get()
        {
            //var profs = ManageProffesseur.ListProf(obj => true);
            return "Profs list";
        }
        public string Get(int id)
        {
            return "value";
        }
    }
}