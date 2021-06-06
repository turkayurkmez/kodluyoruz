using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Models
{
   public class Actor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Notes { get; set; }

        public virtual IList<MovieActor> Movies { get; set; }

    }
}
