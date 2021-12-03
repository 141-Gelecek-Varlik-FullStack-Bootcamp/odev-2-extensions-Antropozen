using System;

namespace CA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime x = DateTime.Now;
            //This part adds 10 hours to our current time and show it on the console screen.
            Console.WriteLine(CL1.Extensions.ToDateTime(x));
            //This part show us our current time on the console screen.
            Console.WriteLine(x.ToString());
            //Show us user type on the console screen.
            Console.WriteLine(CL1.Extensions.GetDisplayName(UserType.UserTypeSecond));
            //This part show us "Hello World" on the console screen.
            Console.WriteLine("Hello World!");
        }
    }
}
