using DogWalk.Models;

using System.Collections.Generic;

namespace DogWalk.Repositories
{
    public interface IWalkerRepository
    {
        List<Walker> GetAllWalkers();
        Walker GetWalkerById(int id);


    }
}