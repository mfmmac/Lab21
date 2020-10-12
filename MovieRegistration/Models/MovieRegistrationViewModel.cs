using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class MovieRegistrationViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genere { get; set; }
        public string Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

    }
}
