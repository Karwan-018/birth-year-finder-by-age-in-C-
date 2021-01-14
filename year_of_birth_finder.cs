using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age ");
            int age = Convert.ToInt32(Console.In.ReadLine());
            int currentYear = DateTime.Now.Year;
            int birthyear = currentYear - age;
            Console.WriteLine("your were born in  " + birthyear);
        }
    }
}
