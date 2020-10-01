using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3c____Distance_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceOne;
            Console.WriteLine("Please enter your first distance (kmph)");
            distanceOne = Convert.ToInt32(Console.ReadLine());

            int distanceTwo;
            Console.WriteLine("Please enter your first distance (kmph)");
            distanceTwo = Convert.ToInt32(Console.ReadLine());
            
            int distanceThree;
            Console.WriteLine("Please enter your first distance (kmph)");
            distanceThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Press any key to find the average of your distances.");
            Console.ReadLine();

            int distanceSum = Convert.ToInt32($"{distanceOne} + {distanceTwo} + {distanceThree}");
            distanceSum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of your distances is {distanceSum}");
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}