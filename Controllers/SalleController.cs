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
    [Route("api/salles")]
    public class SalleController :ApiController
    {
        // GET: Salle
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        // [Route("api/transaction/all")]
        public IEnumerable<SalleEntity> GetSalles()
        {
            //var listTransactions=  ManageTransactions.ListTransactions(t => t.Offers.Contains);
            var list = ManageSalle.ListSalles(t => true);
            return list;
        }
        [AllowAnonymous]
        [AcceptVerbs("POST")]
        [Route("api/salles/add")]
        public async Task<IHttpActionResult> AddSalle([FromBody] SalleEntity s)
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

                result = ManageSalle.ModifySalle(s);
                if (!result)
                {
                    return BadRequest();
                }
            }
            else
            {
                result = ManageSalle.NewSalle(s);
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
        [Route("api/salles/delete/{id}")]
        public async Task<IHttpActionResult> DeleteSalle(int id)
        {
            var result = false;
            var item = ManageSalle.ListSalles(s => s.Id == id).FirstOrDefault();
            if (item != null)
            {
                result = ManageSalle.DeleteSalle(item);
            }
            return Ok(result);
        }
        [AllowAnonymous]
        [AcceptVerbs("GET")]
        [Route("api/salles/one/{id}")]
        public IEnumerable<SalleEntity> GetOneSalle(int Id)
        {
            return ManageSalle.ListSalles(s => (s.Id == Id));
        }
    }
}