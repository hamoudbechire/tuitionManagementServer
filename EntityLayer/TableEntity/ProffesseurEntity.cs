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
        
        [JsonProperty("profId")]
        [Key]
        public int ProfId { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("mail")]
        public string Mail { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("matierId")]
        public int matierId { get; set; }
    }
}
