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
    [Table("Matiere")]
    public class MatiereEntity
    {
        [Key]
        public int IdMatiere { get; set; }
        public string Name { get; set; }
        public int IdClass { get; set; }
        public int IdProf { get; set; }
    }
}
