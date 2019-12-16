using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.Models
{
    public class Post
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter Title")]
        [StringLength(200, ErrorMessage = "Do not enter more than 200 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Email body")]
        public string body { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int UserID { get; set; }


    }
}
