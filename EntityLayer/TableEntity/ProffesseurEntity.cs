using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer

{
    [Table("Professeurs")]
    public class ProffesseurEntity
    {
       // [ForeignKey("Category")]
        
        [Key]
        [JsonProperty("idProf")]
        public int Id { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        [JsonProperty("mail")]
        public string Mail { get; set; }
        public string Phone { get; set; } 
        public int MatierId { get; set; } 
    }
}
