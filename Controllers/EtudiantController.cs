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
        public string Post()
        {
            // return ManageEtudiant.NewEtudiant(etudiant);
            return "je confirmation mon execution";
        }


        [AllowAnonymous]
        public List<EtudiantEntity> GetById(int id)
        {
            return ManageEtudiant.ListEtudiant(t => (t.EtudiantId == id));
        }

    }
}
