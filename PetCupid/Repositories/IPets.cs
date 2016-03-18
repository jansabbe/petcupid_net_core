using PetCupid.Models;
using System.Collections.Generic;

namespace PetCupid.Repositories
{
    public interface IPets {    
        IEnumerable<Pet> GetPets();
        Pet GetPet(int id);
    }
}