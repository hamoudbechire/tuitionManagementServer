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
    [Authorize]
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
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            //if (adress.ServerId == null)
            //{ 
            //    return BadRequest();
            //}
            if (a.Id > 0)
            {

                result = ManageAdmin.ModifyAdmin(a);
                if (!result)
                {
                    return BadRequest();
                }
            }
            else
            {
                result = ManageAdmin.NewAdmin(a);
            }

            if (!result)
            {
                return BadRequest();
            }

            return Ok(a);
        }
        [Authorize]
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
        [Authorize]
        [AcceptVerbs("GET")]
        [Route("api/admins/one/{id}")]
        public IEnumerable<AdminEntity> GetOneAdmin(int Id)
        {
            return ManageAdmin.ListAdmin(a => (a.Id == Id));
        }

    }
}