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
        public int ClasseId { get; set; } 
        public string ClassName { get; set; } 
    }
}
