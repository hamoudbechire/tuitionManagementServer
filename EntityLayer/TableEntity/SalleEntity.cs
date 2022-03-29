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
    [Table("Salle")]
    public class SalleEntity
    {
        [Key]
        [JsonProperty("classId")]
        public int Id { get; set; }
        [JsonProperty("numSalle")]
        public string NumSalle { get; set; }
        [JsonProperty("libre")]
        public Boolean Libre { get; set; } 
    }
}
