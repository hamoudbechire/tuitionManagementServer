using BusinessLayer;
using EntityLayer.TableEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolManagementApi.Controllers
{
    public class ClasseController : ApiController
    {
        [AllowAnonymous]
        [AcceptVerbs("POST")]
        [Route("api/classe/post")]
        public bool NewClasse(ClasseEntity classe)
        {
            return ManageClasse.NewClasse(classe);
        }

        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/classe/list")]
        public List<ClasseEntity> GetAllClasse()
        {
            return ManageClasse.ListClasse(obj => true);
        }
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/classe/{id}")]
        public List<ClasseEntity> GetClasseById(int id)
        {
            return ManageClasse.ListClasse(t => (t.Id == id));
        }
        [AllowAnonymous]
        [AcceptVerbs("PUT")]
        [Route("api/classe/put/{id}")]
        {
            ManageClasse.UpdateClasse(classe);
        }

        [AllowAnonymous]
        [AcceptVerbs("DELETE")]
        [Route("api/classe/delete/{id}")]
        {
            var item = ManageClasse.ListClasse(i => i.Id == id).FirstOrDefault();
            if (item != null)
                ManageClasse.RemoveClasse(item);
        }
    }
}
