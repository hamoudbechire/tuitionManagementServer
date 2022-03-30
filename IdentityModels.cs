using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
 
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNet.Identity;


namespace SchoolManagementApi.Models
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant d'autres propriétés à votre classe ApplicationUser, consultez http://go.microsoft.com/fwlink/?LinkID=317594 pour en savoir davantage.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Notez que authenticationType doit correspondre à l'instance définie dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Ajouter des revendications d’utilisateur personnalisées ici
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

         
        //public System.Data.Entity.DbSet<EntityLayer.ATestEntity> Atests { get; set; }
    }
}