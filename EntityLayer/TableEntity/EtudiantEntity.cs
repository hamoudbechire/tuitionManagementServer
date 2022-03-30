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
        public int EtudiantId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Phone { get; set; } 
    }
}
