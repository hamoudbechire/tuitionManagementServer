using EntityLayer.TableEntity;
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
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; } 
        [JsonProperty("mail")]
        public string Mail { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; } 
        [JsonProperty("matiereId")]
        public int? MatiereId { get; set; }
        [JsonProperty("matiere")]
        [ForeignKey("MatiereId")]
        public MatiereEntity Matiere { get; set; }
    }
}
