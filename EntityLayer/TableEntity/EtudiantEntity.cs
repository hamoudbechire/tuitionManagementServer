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
    [Table("etudiant")]
    public class EtudiantEntity
    {
        [Key]
        [JsonProperty("etudiantId")]
        public int EtudiantId { get; set; }
        [JsonProperty("firstname")]
        public string FirstName { get; set; }
        [JsonProperty("lastname")]
        public string LastName { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("classes")]
        public List<ClasseEntity> Classes { get; set; }
    }
}
