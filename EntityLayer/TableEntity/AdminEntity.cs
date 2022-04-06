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
    [Table("Admin")]
    public class AdminEntity
    {
        [Key]
        [JsonProperty("adminId")]
        public int Id { get; set; }
        [JsonProperty("firstName")] 
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("profilImageUrl")]
        public string ProfilImageUrl { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
        [JsonProperty("modificationDate")]
        public DateTime ModificationDate { get; set; }
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("isActivated")]
        public bool IsActivated { get; set; }

    }
}
