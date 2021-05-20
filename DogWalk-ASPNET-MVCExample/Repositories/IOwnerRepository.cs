using DogWalk.Models;

using System.Collections.Generic;

namespace DogWalk.Repositories
{
    public interface IOwnerRepository
    {
        void AddOwner(Owner owner);
        void DeleteOwner(int ownerId);
        List<Owner> GetAllOwners();
        Owner GetOwnerByEmail(string email);
        Owner GetOwnerById(int id);
        void UpdateOwner(Owner owner);
    }
}