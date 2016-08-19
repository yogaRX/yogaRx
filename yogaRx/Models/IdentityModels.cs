using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace yogaRx.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string UserHandle { get; set; }
        public string ProPhoto { get; set; }
        public string PhotoName { get; set; }
        public string PhotoType { get; set; }
        public byte[] PhotoBytes { get; set; }
        public FileType FileType { get; set; }

        //Navigation
        public virtual ICollection<Rating> Ratings { get; set; }
        


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
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

        public System.Data.Entity.DbSet<yogaRx.Models.Pose> Poses { get; set; }

        public System.Data.Entity.DbSet<yogaRx.Models.Ailment> Ailments { get; set; }

        public System.Data.Entity.DbSet<yogaRx.Models.Rating> Ratings { get; set; }

    }
}