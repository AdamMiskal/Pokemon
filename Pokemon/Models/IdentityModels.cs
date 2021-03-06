using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Validation;
using System.Linq;
using System;

namespace Pokemon.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        //public DateTime BirthDate { get; set; }
        public double Balance { get; set; }
       
        public ICollection<Card> Cards  { get; set; }
        
        

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
            : base("Sindesmos", throwIfV1Schema: false)
        {
                   



        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.PropertyName + ": " + x.ErrorMessage));
                throw new DbEntityValidationException(errorMessages);
            }
        }

        public static ApplicationDbContext Create()
        {

            
            return new ApplicationDbContext();
        }
     

        
        public DbSet<Card> Cards { get; set; }
        public DbSet<PokemonType> PokemonType { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Sales> Sales { get; set; }


       
        
        //public System.Data.Entity.DbSet<Pokemon.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}