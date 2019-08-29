using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class WaterLab
    { 
        static void Main()
         {

            /*
             * Write a program that will: 
             * 
             * - Assume that a gallon of water weighs 8.33 pounds
             * - Prompt the user to enter a number of gallons
             * - Display the total weight of the water in pounds
             * 
             * Test with something simple like 2 to start. 
             */
             
            Console.Write("How many gallons of water do you use a day? ");
            decimal useOfWater = Convert.ToDecimal (Console.ReadLine());
            decimal totalLbs = 8.33m;

            Console.WriteLine("The total amount water you use is " + useOfWater * totalLbs + " LBS ");
            
        }//end Main ()
    }//end class
}//end namespace
