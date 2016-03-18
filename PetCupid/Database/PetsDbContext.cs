using Microsoft.Data.Entity;
using PetCupid.Models;

namespace PetCupid.Database
{
    public class PetsDbContext : DbContext
    {
        public DbSet<Pet> Pet { get; set; }
       
        protected override void OnModelCreating(ModelBuilder builder)
        { 
            base.OnModelCreating(builder); 
        } 
    }
}