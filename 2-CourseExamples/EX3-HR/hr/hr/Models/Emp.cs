using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace hr.Models
{
    public class Emp
    {
        public int id { get; set; }

        public String Name { get; set; }

        public float Sal { get; set; }

        public int DeptID { get; set; }
        public Dept Dept { get; set; }
    }
}
