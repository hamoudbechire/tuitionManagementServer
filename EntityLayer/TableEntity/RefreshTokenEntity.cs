using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityLayer
{
    [Table("RefreshTokens")]
    public class RefreshTokenEntity
    {
        [Key]
        [JsonProperty("serverId")]
        public string Id { get; set; }
        [Required]
        [MaxLength(50)]
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [Required]
        [MaxLength(50)]
        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        [JsonProperty("issuedUtc")]
        public DateTime IssuedUtc { get; set; }
        [JsonProperty("expiresUtc")]
        public DateTime ExpiresUtc { get; set; }
        [Required]
        [JsonProperty("protectedTicket")]
        public string ProtectedTicket { get; set; }
        [JsonProperty("facebookToken")]
        public string FacebookToken { get; set; }
    }
}