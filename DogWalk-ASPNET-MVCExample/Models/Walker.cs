﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalk.Models
{
    public class Walker
    {
        public int Id { get; set; }
        public string Name { get; set; }
 
        public string ImageUrl { get; set; }

        public Owner Owner { get; set; }

    }
}
