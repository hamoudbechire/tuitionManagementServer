using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.TableEntity
{
    [Table("Salle")]
    public class SalleEntity
    {
        [Key]
        [JsonProperty("classId")]
        public int Id;
        [JsonProperty("numSalle")]
        public string NumSalle;
        [JsonProperty("libre")]
        public Boolean Libre; 
    }
}
