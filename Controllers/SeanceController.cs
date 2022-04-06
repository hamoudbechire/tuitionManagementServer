using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EntityLayer;
using BusinessLayer;
using System.Threading.Tasks;

namespace SchoolManagementApi.Controllers
{
    [Authorize]
    [Route("api/seances")]
    public class SeanceController : ApiController
    {
        // GET: Seance
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        // [Route("api/transaction/all")]
        public IEnumerable<SeanceEntity> GetSeances()
        {
            //var listTransactions=  ManageTransactions.ListTransactions(t => t.Offers.Contains);
            var list = ManageSeances.ListSeances(t => true);
            return list;
        }
        [AllowAnonymous]
        [AcceptVerbs("POST")]
        [Route("api/seances/add")]
        public async Task<IHttpActionResult> AddSeance([FromBody] SeanceEntity s)
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
            if (s.Id > 0)
            {

                result = ManageSeances.ModifySeance(s);
                if (!result)
                {
                    return BadRequest();
                }
            }
            else
            {
                result = ManageSeances.NewSeance(s);
            }

            if (!result)
            {
                return BadRequest();
            }

            return Ok(s);
        }
        [AllowAnonymous]
        [AcceptVerbs("DELETE")]
        //[Route("api/employe/delete/{id}")]
        [Route("api/seances/delete/{id}")]
        public async Task<IHttpActionResult> DeleteSeance(int id)
        {
            var result = false;
            var item = ManageSeances.ListSeances(s => s.Id == id).FirstOrDefault();
            if (item != null)
            {
                result = ManageSeances.DeleteSeance(item);
            }
            return Ok(result);
        }
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/seances/one/{id}")]
        public IEnumerable<SeanceEntity> GetOne(int Id)
        {
            return ManageSeances.ListSeances(s => (s.Id == Id));
        }
    }
}