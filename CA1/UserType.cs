using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    public enum UserType
    {
        //The type of the object is defined.
        [Display(Name = "Admin")]
        UserTypeFirst = 1,
        [Display(Name = "Developer")]
        UserTypeSecond = 2,
        [Display(Name = "User")]
        UserTypeThird = 3,

    }
}
