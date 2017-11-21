using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopAssignment
{
    class Question1
    {
        static void Main(string[] args)
        {
            //Declare variables
            decimal grossPay, taxPayable, netPay;

            //Request input from user
            Console.WriteLine("Enter your Gross Pay: ");
            grossPay = decimal.Parse(Console.ReadLine());

            //Calculate Taxable Amount, Tax Payable and Net Pay
            if (grossPay < 10000)
            {
                Console.WriteLine("No tax will be deducted.\n Your Net Pay is {0:0.00} euros", grossPay);
            }
            else if (grossPay > 10000 && grossPay < 50000)
            {
                taxPayable = ((grossPay - 10000) * 20 / 100);
                netPay = grossPay - taxPayable;
                Console.WriteLine("Tax on {0} euros is {1:0.00} euros. \n Net Pay is {2:0.00} euros", grossPay, taxPayable, netPay);
            }

            else if (grossPay > 50000)
            {
                taxPayable = ((grossPay - 50000) * 40 / 100) + (40000 * 20 / 100);
                netPay = grossPay - taxPayable;
                Console.WriteLine("Tax on {0} euros is {1:0.00} euros. \n NetPay is {2:0.00}", grossPay, taxPayable, netPay);
            }
            Console.Read();
        }
    }
}
