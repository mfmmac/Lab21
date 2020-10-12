using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Models
{
    public class MovieRegistrationResultViewModel
    {
        public string Title { get; set; }
        public string Genere { get; set; }
        public string Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }
        public string Result { get; set; }
    }
}
