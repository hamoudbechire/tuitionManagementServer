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
        // POST api/emails
        public bool Post([FromBody]ClasseEntity classe)
        {
            return ManageClasse.NewClasse(classe);
        }
    }
}
