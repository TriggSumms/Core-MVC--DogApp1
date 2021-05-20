using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalk.Models
{
    public class Dog
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int OwnerId { get; set; }

        public Owner owner { get; set; }

        [Required]
        public string Breed { get; set; }

        
        [DisplayName("Picture")]
        public string ImageUrl { get; set; }
        public string Notes { get; set; }
    }
}
