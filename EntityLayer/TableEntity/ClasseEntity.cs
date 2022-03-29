using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.TableEntity
{
    [Table("etudiant")]
    public class ClasseEntity
    {

        [Key]
        [JsonProperty("classId")]
        public int ClasseId { get; set; }
        [JsonProperty("className")]
        public string ClassName { get; set; }
        public List<EtudiantEntity> etudiants { get; set; }
        public List<ProffesseurEntity> proffesseurs { get; set; }


    }
}
