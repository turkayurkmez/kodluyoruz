using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models
{
   public class MovieActor
    {
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        public  Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
