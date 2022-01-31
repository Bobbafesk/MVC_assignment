using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_assignment.Models
{
    public class DoctorModel
    {
        public static string CheckIfFever(int temp)
        {
            if (temp > 37)
            {
                return "You got fever";
            }
            else
            {
                return "You got No fever";
            }

        }
    }
}
