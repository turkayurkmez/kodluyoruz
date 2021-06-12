using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movies.Business.DataTransferObjects
{
   public class AddNewGenreRequest
    {
        [Required(ErrorMessage = "Tür adını belirtmediniz!!!")]
        public string Name { get; set; }
    }
}
