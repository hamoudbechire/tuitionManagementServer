using EntityLayer.TableEntity;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolManagementApi.Controllers
{
    public class EtudiantController : ApiController
    {
        [AllowAnonymous]
        // POST api/emails
        public bool Post([FromBody] EtudiantEntity etudiant)
        {
            return ManageEtudiant.NewEtudiant(etudiant);
           // return "je confirmation mon execution";
        }


        [AllowAnonymous]
        public List<EtudiantEntity> GetById(int id)
        {
            return ManageEtudiant.ListEtudiant(t => (t.EtudiantId == id));
        }

        public void EditerEtudiant([FromBody] EtudiantEntity etudiant)
        {
            ManageEtudiant.UpdateEtudiant(etudiant);
        }

        // DELETE api/emails/5
        public void Delete(int id)
        {
            var item = ManageEtudiant.ListEtudiant(i => i.Id == id).FirstOrDefault();
            if (item != null)
                ManageEtudiant.RemoveEtudiant(item);
        }

    }
}
