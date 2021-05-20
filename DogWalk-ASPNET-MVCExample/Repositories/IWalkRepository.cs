using DogWalk.Models;
using System.Collections.Generic;
using System;


namespace DogWalk.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetAll();

        //List<Walk> GetWalksByTheWalker(int id);

        //List<Walk> GetWalksByTheDog(int id);

        List<Walk> GetALLWalksandIds(int id);
    }
}