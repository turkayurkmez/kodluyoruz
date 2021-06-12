using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Models
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Film adı boş olamaz!")]
        [MinLength(2,ErrorMessage ="Film adı en az 2 karakter olmalı")]
        [MaxLength(200, ErrorMessage = "Film adı en az 2 karakter olmalı")]

        public string Title { get; set; }
        public decimal? Price { get; set; }
        public string PosterPath { get; set; }

        public int? GenreId { get; set; }

        //Navigation Property
        public virtual Genre Genre { get; set; }

        public virtual IList<MovieActor> Actors { get; set; }

    }
}
