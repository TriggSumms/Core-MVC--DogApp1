using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DogWalk.Models;
using DogWalk.Models.ViewModels;
using DogWalk.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace DogWalk.Controllers
{
    //If I was to change the public class name of walker and use intelisense....it would change the occurences and then by changing the file name and index.cshtml....I could chage the url link name
    //
    public class WalkersController : Controller
    {
        private readonly IWalkerRepository _walkerRepo;

        //private readonly IDogRepository _dogRepo;
       

        private readonly IWalkRepository _walkRepo;

        private readonly IOwnerRepository _ownerRepo;


        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalkersController(
            IWalkerRepository walkerRepository,
            
            IWalkRepository walkRepository,
           
            IOwnerRepository ownerRepository)
        {
            _walkerRepo = walkerRepository;
            
            _walkRepo = walkRepository;
            _ownerRepo = ownerRepository;

        }


        private int GetCurrentUserId()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(id);
        }





        public ActionResult Index()
        {
            //Chp 6 currentUserId attached to index, two lists generated based on logged in/out and list based on neighborhood match
            int ownerId = GetCurrentUserId();
            Owner theOwner = _ownerRepo.GetOwnerById(ownerId);
           
            List<Walker> walkers = _walkerRepo.GetAllWalkers();

            if (ownerId != 0)
            {
                
                return View(walkers);
            }
            else
            {
                
                return View(walkers);
            }
        }

        // GET: Walkers
        //public IActionResult Index()
        //{
        //    List<Walker> walkers = _walkerRepo.GetAllWalkers();

        //    return View(walkers);
        //}
        // GET: Walkers/Details/5







        public ActionResult Details(int id)
        {
            Walker walker = _walkerRepo.GetWalkerById(id);
            List<Walk> walks = _walkRepo.GetALLWalksandIds(walker.Id);


            //We used the items declared above.....to pair our new lists/paramenters with the requested Id 
            //and then shoved it into a profileVIEW, then we returned it. (Had to change details panel)
            WalkerDetailsViewModel vm = new WalkerDetailsViewModel()
            {
                Walker = walker,
               // Dogs = dogs,
                Walks = walks
            };

            return View(vm);
        }


    }
}
