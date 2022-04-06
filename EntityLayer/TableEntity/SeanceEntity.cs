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
    [Table("Seance")]
    public class SeanceEntity
    {
        [Key]
        [JsonProperty("seancerId")]
        public int Id { get; set; }
        [JsonProperty("dateDebut")]
        public DateTime DateDebut { get; set; }
        [JsonProperty("dateFin")]
        public DateTime DateFin { get; set; }

        [JsonProperty("classeId")]
        public int? ClasseId { get; set; }
        [JsonProperty("classe")]
        [ForeignKey("ClasseId")]
        public ClasseEntity Classe { get; set; }

        [JsonProperty("profId")]
        public int? ProfId { get; set; }
        [JsonProperty("professeur")]
        [ForeignKey("ProfId")]
        public ProffesseurEntity Professeur { get; set; }

        [JsonProperty("matiereId")]
        public int? MatiereId { get; set; }
        [JsonProperty("matiere")]
        [ForeignKey("MatiereId")]
        public ProffesseurEntity Matiere { get; set; }

    }
}
