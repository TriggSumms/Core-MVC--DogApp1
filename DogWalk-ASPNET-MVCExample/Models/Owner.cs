using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalk.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(55, MinimumLength = 5)]
        public string Address { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }

    }
}
