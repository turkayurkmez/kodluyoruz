using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Models
{
   public class Actor : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Film adı boş olamaz!")]
        [MinLength(2, ErrorMessage = "Film adı en az 2 karakter olmalı")]
        [MaxLength(200, ErrorMessage = "Film adı en az 2 karakter olmalı")]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }

        public virtual IList<MovieActor> Movies { get; set; }

    }
}
