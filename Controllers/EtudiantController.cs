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
        [AcceptVerbs("POST")]
        [Route("api/etudiant/add")]
        public bool AddNewEtudiant([FromBody] EtudiantEntity etudiant)
        {
            return ManageEtudiant.NewEtudiant(etudiant);
        }
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/etudiant/list")]
        public List<EtudiantEntity> GetAllEtudiant()
        {

  

            var etudiants = ManageEtudiant.ListEtudiant(obj => true);
            return etudiants;

        }
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/etudiant")]
        public List<EtudiantEntity> GetEtudiantById(int id)
        {
            return ManageEtudiant.ListEtudiant(t => (t.Id == id));
        }
        [AllowAnonymous]
        [AcceptVerbs("PUT")]
        [Route("api/etudiant/update/id")]

        public void EditEtudiant([FromBody] EtudiantEntity etudiant)
        {
            ManageEtudiant.UpdateEtudiant(etudiant);
        }
        [AllowAnonymous]
        [AcceptVerbs("DELETE")]
        [Route("api/etudiant/delete/{id}")]
        public void DeleteEtudiant(int id)
        {
            var item = ManageEtudiant.ListEtudiant(i => i.Id == id).FirstOrDefault();
            if (item != null)
                ManageEtudiant.RemoveEtudiant(item);
        }

    }
}
