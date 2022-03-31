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
        //[Route("api/etudiant/post")]
        public bool AjouterClasse(ClasseEntity classe)
        {
            return ManageClasse.NewClasse(classe);
        }
        [AllowAnonymous]
       // [Route("api/etudiant/get/id?")]
        public List<ClasseEntity> GetById(int id)
        {
            return ManageClasse.ListClasse(t => (t.Id == id));
        }
        //[Route("api/etudiant/put/id?")]
        public void EditerClasse([FromBody] ClasseEntity classe)
        {
            ManageClasse.UpdateClasse(classe);
        }

        //[Route("api/etudiant/delete/id?")]
        public void SupprimerClasse(int id)
        {
            var item = ManageClasse.ListClasse(i => i.Id == id).FirstOrDefault();
            if (item != null)
                ManageClasse.RemoveClasse(item);
        }
    }
}
