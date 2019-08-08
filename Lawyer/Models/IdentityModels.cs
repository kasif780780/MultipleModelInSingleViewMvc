using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Lawyer.DTOModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Lawyer.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
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
        public DbSet<Award> Awards { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Case>Cases { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Law> Laws { get; set; }
        public DbSet<TLawyer> TLawyer { get; set; }
        public DbSet<NavSectionBrand> NavSectionBrands { get; set; }
        public DbSet<PracticeArea> PracticeAreas { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SliderSection> SliderSections { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamPerson> TeamPersons { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<WhyChooseUs> WhyChooseUs { get; set; }
        public DbSet<Category> Categories { get; set; }
        


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}