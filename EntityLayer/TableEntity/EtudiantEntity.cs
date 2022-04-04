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
        public int Id { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("classeServerId")]
        public int? ClasseId { get; set; }
        [JsonProperty("classe")]
        [ForeignKey("ClasseId")]
        public ClasseEntity Classe { get; set; }
    }
}
