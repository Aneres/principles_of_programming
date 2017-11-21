using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopAssignment
{
    class Question2
    {
        static void Main()
        {   //declare variables
            double number, highestNumber = 0, lowestNumber = 100, evenCount = 0, sum = 0;
            decimal average;

            //Request numbers from user
            do
            {
                Console.Write("Enter a number between 1 and 100: ");
                number = double.Parse(Console.ReadLine());

            //Check validity of numbers input
                if (number < 1 || number > 100)
                {
                    break;
                }

                if (number % 2 == 0)
                {
                    sum = number + sum                                                                                                                  
                    evenCount++;

                    if (number > highestNumber)

                        highestNumber = number;

                    if (number < lowestNumber)

                        lowestNumber = number;
                }
                 
            } while (number >= 1 && number <= 100);

            average =(decimal) sum / (decimal) evenCount;
            Console.WriteLine("\nThe number of even numbers entered:{0}", evenCount);
            Console.WriteLine("The sum of even numbers entered is: {0}", sum);
            Console.WriteLine("The average of even numbers entered is: {0:00.00}",average);
            Console.WriteLine("The highest number entered is: {0} ", highestNumber);
            Console.WriteLine("The lowest number entered is: {0}", lowestNumber);

            Console.Read();
        }
    }
}
