using System.Collections.Generic;
using PetCupid.Models;
using PetCupid.Database;
using System.Linq;

namespace PetCupid.Repositories
{
    public class Pets : IPets
    {
        private List<Pet> pets;
        private PetsDbContext _petsContext;
        
        public Pets(PetsDbContext petsContext) {
            _petsContext = petsContext;
            
            pets = new List<Pet>();
            
            pets.Add(new Pet {
                Name = "Princess",
                Kind = "chicken",
                Image = "images/chicken1.jpg",
                ProfileText = "Meet Princess Fluffybutt! She is one of the fluffiest chickens you will ever meet. Most often you'll find Princess cuddled up in the warmest spot she can find, and if that happens to be in your lap, well then that's fine for her too! Princess also enjoys nomming treats out of your hand, clucking softly under her breath, and following her three sisters around the yard. Get to know Princess today!"
            });
            pets.Add(new Pet {
                Name = "MrFuzz",
                Kind = "cat",
                Image = "images/cat1.jpg",
                ProfileText = "MrFuzz loves belly rubs, and likes playing with pieces of string"
            });
            pets.Add(new Pet {
                Name = "Burt",
                Kind = "dog",
                Image = "images/dog1.jpg",
                ProfileText = "Burt looks cute, but is in reality a though guy. Secretly wants to work for the FBI"
            });
            pets.Add(new Pet {
                Name = "MissPoes",
                Kind = "cat",
                Image = "images/cat2.jpg",
                ProfileText = "MissPoes is a classy lady who appreciates gentle pets"
            });
            pets.Add(new Pet {
                Name = "Lady",
                Kind = "dog",
                Image = "images/dog2.jpg",
                ProfileText = "Lady isn't always very lady-like. She loves rolling in the mud and barking at naughty squirrels"
            });
            pets.Add(new Pet {
                Name = "Grumpy",
                Kind = "cat",
                Image = "images/cat3.jpg",
                ProfileText = "Grumpy basically hates everything, especially dogs. He does looove lasagne though"
            });
            pets.Add(new Pet {
                Name = "Bobby",
                Kind = "dog",
                Image = "images/dog3.jpg",
                ProfileText = "Bobby loves to fetch balls and chase rabbits. Great with kids."
            });
            
            _petsContext.AddRange(pets);
            _petsContext.SaveChanges();
        }

        public IEnumerable<Pet> GetPets() {
            return _petsContext.Pet.ToList();
        }
        
        public Pet GetPet(int id) {
            return _petsContext.Pet.Where(pet => pet.Id == id).FirstOrDefault();
        }
    }
}