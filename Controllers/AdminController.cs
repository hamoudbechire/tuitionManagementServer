using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EntityLayer;
using BusinessLayer;
using System.Threading.Tasks;
 
using System.Net;
using System.Net.Mail;
 

namespace SchoolManagementApi.Controllers
{
   //:: [Authorize]
    [Route("api/admins")]
    public class AdminController : ApiController
    {
        // GET: Admin
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        // [Route("api/transaction/all")]
        public IEnumerable<AdminEntity> GetAdmins()
        {
            //var listTransactions=  ManageTransactions.ListTransactions(t => t.Offers.Contains);
            var listEmployes = ManageAdmin.ListAdmin(t => true);
            return listEmployes;
        }
        [AllowAnonymous]
        [AcceptVerbs("POST")]
        [Route("api/admins/add")]
        public async Task<IHttpActionResult> AddAdmin([FromBody] AdminEntity a)
        {
            var result = false;
            var admin = ManageAdmin.ListAdmin(p => p.Email == a.Email || (p.Phone != null && p.Phone == a.Phone)).FirstOrDefault();
            if (admin != null)
            {
                return InternalServerError(new ArgumentException("You have Already an account !"));
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (a.Password != null)
            {   
                a.Password = Helper.GetHash(a.Password);
            }
            if (a.Id > 0)
            {
                a.ModificationDate = DateTime.Now;
                result = ManageAdmin.ModifyAdmin(a);
                if (!result)
                {
                    return BadRequest();
                }
            }
            else
            {
                a.CreationDate = DateTime.Now;
                a.ModificationDate = DateTime.Now;
                result = ManageAdmin.NewAdmin(a);
            }

            if (!result)
            {
                return BadRequest();
            }

            return Ok(a);
        }
        [AllowAnonymous]
        [AcceptVerbs("DELETE")]
        //[Route("api/employe/delete/{id}")]
        [Route("api/admins/delete/{id}")]
        public async Task<IHttpActionResult> DeleteAdmin(int id)
        {

            var result = false;
            var item = ManageAdmin.ListAdmin(a => a.Id == id).FirstOrDefault();
            if (item != null)
            {
                result = ManageAdmin.DeleteAdmin(item);
            }
            return Ok(result);
        }
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/admins/one/{id}")]
        public IEnumerable<AdminEntity> GetOneAdmin(int Id)
        {
            return ManageAdmin.ListAdmin(a => (a.Id == Id));
        }
        [AllowAnonymous]
        [Route("api/admins/findAdmin/{phone}")]
        public AdminEntity Get(string phone)
        {
            //var convertIdentifian = "";
            //if (idnetifiant.Contains('~'))
            //{
            //    convertIdentifian = idnetifiant.Replace("~", "+");
            //}
            //else
            //{
            //    convertIdentifian = idnetifiant;
            //}
            var user = ManageAdmin.ListAdmin(i => (i.Phone == phone)).FirstOrDefault();
            return user;
        }


    }
}