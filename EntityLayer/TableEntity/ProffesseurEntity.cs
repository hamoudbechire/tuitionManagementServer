using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.TableEntity
{
    [Table("Proffesseur")]
    public class ProffesseurEntity
    {

        [Key] 
        public int ProfId { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Mail { get; set; } 
        public string Phone { get; set; } 
        public int MatierId { get; set; }
    }
}
