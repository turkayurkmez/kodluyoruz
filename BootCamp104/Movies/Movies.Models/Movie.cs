using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string PosterPath { get; set; }

        public int GenreId { get; set; }

        //Navigation Property
        public virtual Genre Genre { get; set; }

        public virtual IList<MovieActor> Actors { get; set; }

    }
}
