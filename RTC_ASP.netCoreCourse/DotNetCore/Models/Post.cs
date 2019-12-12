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

        [StringLength(10, ErrorMessage = "Do not enter more than 10 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Email body")]
        public string body { get; set; }
        public int UserID { get; set; }

    }
}
