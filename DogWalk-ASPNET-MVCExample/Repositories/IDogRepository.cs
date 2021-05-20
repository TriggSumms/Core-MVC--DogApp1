using DogWalk.Models;

using System.Collections.Generic;

namespace DogWalk.Repositories
{
    public interface IDogRepository
    {
       void AddDog(Dog dog);
        void DeleteDog(int dogId);
      
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        void UpdateDog(Dog dog);
        List<Dog> GetDogsByOwnerId(int ownerId);

        List<Dog> GetDogsByWalkerId(int id);
    }
}