using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace hr.Models
{
    public class Dept
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter Title")]
        public string Name { get; set; }

    }
}
