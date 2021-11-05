using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Tipcalculator
        
    {
        public Tipcalculator()
        {
            //Get the bill amount from the user
            Console.WriteLine("Enter bill amount");
            string Bill = Console.ReadLine();
            float amount = float.Parse(Bill);

            //Validate the value from the user to make sure it is a number
            try
            {
               amount = float.Parse(Console.ReadLine());
            }
                catch (Exception ex)
            {
                Console.WriteLine("Please enter a valid bill amount");
            }

            //Ask the user how much they want to tip - show 10,15,20 percent options
            Console.WriteLine("How much do you want to tip?");
            string tip = Console.ReadLine();
            float money = float.Parse(tip);
            money = money / 100;

            //Calculate tip amount from the bill amount and the percentage user chooses.
            float total = amount * money;

            //Show the final bill = bill amount + tip amount 
            float charge = amount + total;
            Console.WriteLine($"thank you for the tip. Your total is {charge}");
            Console.ReadKey();
        }
    }
}
