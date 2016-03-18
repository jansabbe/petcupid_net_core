using Xunit;
using PetCupid.Database;
using PetCupid.Repositories;
using System.Linq;
using PetCupid.Models;

namespace PetCupid.Tests
{
    public class PetsDbContextTests
    {
        public void GetPets()
        {
            // GIVEN 
            
            
            // WHEN
            
            // THEN
            //Assert.That(Calculator.Add(x, y), Is.EqualTo(expected));
        }
    }
    
    public class SampleTest
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        public void PetsRepoShouldBeSameAsDb() 
        {
            PetsDbContext context = new PetsDbContext();
            Pets petsRepo = new Pets(context);
            
            var dbResult = context.Pet.ToList();
            var repoResult = petsRepo.GetPets();
            
            Assert.Equal(dbResult, repoResult);
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}