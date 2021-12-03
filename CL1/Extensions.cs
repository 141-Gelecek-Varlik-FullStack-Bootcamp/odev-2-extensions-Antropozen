using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace CL1
{
    public static class Extensions
    {
        //It add 10 hours to the current time and calculate the new time after ten hours.
        public static string ToDateTime(this DateTime _variable)
        {
            return _variable.AddHours(10).ToLongTimeString();
        }


        //Getting types 
        public static string GetDisplayName(this Enum userType)
        {
            var result = userType.GetType().GetMember(userType.ToString()).First().GetCustomAttributes<DisplayAttribute>().First().Name;
            return result;
        }
    }
}
 