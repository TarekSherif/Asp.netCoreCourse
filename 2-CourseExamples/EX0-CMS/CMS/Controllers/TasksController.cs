using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.Controllers
{
    public class TasksController : Controller
    {
        public decimal AvgEvent(int n)
        {
            if (n > 0)
            {
                int sum = 0;
                for (int i = 0; i <= n * 2; i += 2)
                {
                    sum += i;


                }
                return sum / n;
            }
            return 0;
        }
    }
}