using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Models
{
    public class Place
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "PlaceID is required")]
        public int PlaceID { get; set; }

        [Required(ErrorMessage = "ParkID is required")]
        public int ParkID { get; set; }
        public Park Park { get; set; }

        [Required(ErrorMessage = "Start Time is required")]
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

    }
}
