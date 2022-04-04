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
        public bool AddNewClasse([FromBody]  ClasseEntity classe)
        {
            return ManageClasse.NewClasse(classe);
        }
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/classe/list")]
        public List<ClasseEntity> GetAllClasse()
        {
            var classes = ManageClasse.ListClasse(obj => true);
            return classes;
        }
        [AllowAnonymous]
        [Route("api/classe/get/{id}")]
        public List<ClasseEntity> GetClasseById(int id)
        {
            return ManageClasse.ListClasse(t => (t.Id == id));
        }
        [Route("api/classe/put/{id}")]
        public void EditClasse([FromBody] ClasseEntity classe)
        {
            ManageClasse.UpdateClasse(classe);
        }

        [Route("api/classe/delete/{id}")]
        public void DeleteClasse(int id)
        {
            var item = ManageClasse.ListClasse(i => i.Id == id).FirstOrDefault();
            if (item != null)
                ManageClasse.RemoveClasse(item);
        }
    }
}
