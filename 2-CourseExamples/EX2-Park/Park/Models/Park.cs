using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Models
{
    public class Park
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Park Name is required")]
        [StringLength(160)]
        public String Name { get; set; }
        public string Location { get; set; }
        [Required(ErrorMessage = "costPerHouser is required")]
        public decimal costPerHouser { get; set; }
    }
}
