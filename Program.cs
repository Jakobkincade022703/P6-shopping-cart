/* Name: jakob kincade
 * Section: CS258-00x
 * Date:11/10/24
 * Program description: 
 */
using System;
using System.ComponentModel.Design;
using System.Numerics;

namespace CS258
{
    class ShoppingCart
    {
        static void Main(string[] args)
        {
            // Define variables: item counter and price sum
            const double salestax = 0.075;
            int iCount = 0; //users item count
            double iPrice;  // users input price
            double preTotal = 0 ;
            double shipCost;
            string breakOrNot;
            // The do-while loop
            // Textbook@P357
            do
            {

                // Ask user input for the item price

                Console.WriteLine("what is your item price, please ensure price is positive!");
                iPrice = Convert.ToDouble(Console.ReadLine()); //converting users price input

                // Update the current number of items
                ++iCount;
                Console.WriteLine("your current number of items in cart is" + " " + iCount);
                // The number of items determines the shipping cost
                if (preTotal >= 100)
                {
                    shipCost = 0;
                }
                else
                {
                    if (iCount < 3)
                    {
                        shipCost = 3.50;
                    }
                    else if (iCount <= 6 && iCount >= 3)
                    {
                        shipCost = 5.00;
                    }
                    else if (iCount > 6 && iCount < 10)
                    {
                        shipCost = 7.00;
                    }
                    else if (iCount > 10 && iCount < 15)
                    {
                        shipCost = 9.00;
                    }
                    else
                        shipCost = 10.00;
                }



                // Update the current price sum 
                preTotal = +iPrice;

                // Check if the user is qualified for free shipping
                if (preTotal > 90 && preTotal < 100)
                {
                    Console.WriteLine(" you are only" + " " + (100 - preTotal)+"$" + " " + "away from free shipping!");
                }
                else if (preTotal > 100)
                {

                    Console.WriteLine("you have earned free shipping!");
                }
              

                // To continue or break a loop
                Console.WriteLine("Would you like to continue your shopping experince? please state yes or no");
                breakOrNot = Console.ReadLine();

                if (breakOrNot == "no" || breakOrNot == "No")
                {
                    continue;

                }
                else
                    if (breakOrNot == "yes" || breakOrNot == "Yes")
                {
                    break;
                }
                else { continue; }
             
            }
            while (true);

            
            // Calculate sales tax, shipping cost etc
            
            double grandTotal = (preTotal * salestax) + preTotal + shipCost;

            // Print Total purchase charge, number of items purchased,

            Console.WriteLine("Your total charge is" + " " + grandTotal);
            Console.WriteLine(" ");
            Console.WriteLine("You bought" + " " + iCount + " " + " Items with us today!");
            Console.WriteLine(" ");
            Console.WriteLine("Your total sales tax is" + " " + (preTotal * salestax));
            Console.WriteLine(" ");
            Console.WriteLine("Your Shipping fee is" + " " + shipCost);
            // sales tax amount, shipping charge, and the grand total

        }
    }
}
