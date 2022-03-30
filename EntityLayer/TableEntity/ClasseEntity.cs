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
    [Table("classe")]
    public class ClasseEntity
    {

        [Key]
        [JsonProperty("idClasse")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("etudiants")]
        public List<EtudiantEntity> Etudiant { get; set; }
       // public List<EtudiantEntity> etudiants { get; set; }
    }
}
