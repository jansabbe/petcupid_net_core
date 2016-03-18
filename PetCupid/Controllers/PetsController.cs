using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using PetCupid.Models;
using PetCupid.Repositories;

namespace PetCupid.Controllers
{
    [Route("api/[controller]")]
    public class PetsController : Controller
    {
        private Pets _pets;
        
        public PetsController(Pets pets) {
            _pets = pets;
        }
        
        [HttpGet]
        public IEnumerable<Pet> Get()
        {
            return _pets.GetPets();
        }

        [HttpGet("{id}")]
        public Pet Get(int id)
        {
            return _pets.GetPet(id);
        }
    }
}
