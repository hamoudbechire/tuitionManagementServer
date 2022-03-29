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
    [Table("Admin")]
    public class AdminEntity
    {
        [Key]
        [JsonProperty("adminId")]
        public int Id;
        [JsonProperty("firstName")]
        public string FirstName;

    }
}
