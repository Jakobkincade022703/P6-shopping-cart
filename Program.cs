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
            const double salestax = 0.0775;
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
                Console.WriteLine(" ");

                iPrice = Convert.ToDouble(Console.ReadLine()); //converting users price input

                // Update the current number of items
                ++iCount;
                preTotal += iPrice;
                Console.WriteLine("your current number of items in cart is" + " " + iCount);
                Console.WriteLine(" ");

                // The number of items determines the shipping cost

                Console.WriteLine("your running total is " + "" + preTotal.ToString("C"));
                Console.WriteLine(" ");

                if (preTotal >= 100)
                {
                    shipCost = 0;
                      Console.WriteLine(" You have earned free shipping!");
                      Console.WriteLine(" ");

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
            

                // Check if the user is qualified for free shipping
                if (preTotal > 90 && preTotal < 100)
                {
                    Console.WriteLine(" you are only" + " " + (100 - preTotal).ToString("C") + " " + "away from free shipping!");
                    Console.WriteLine(" ");

                }
                

                // To continue or break a loop
                Console.WriteLine("Would you like to continue your shopping experince? please state 'yes' or 'no'. if you state otherwise this will repeat");
                Console.WriteLine(" ");
                breakOrNot = Console.ReadLine();

                if (breakOrNot == "no" || breakOrNot == "No")
                {
                    break;

                }
                else
                    if (breakOrNot == "yes" || breakOrNot == "Yes")
                {
                    continue;
                }
                else { continue; }
             
            }
            while (true);

            
            // Calculate sales tax, shipping cost etc
            
            double grandTotal = (preTotal * salestax) + preTotal + shipCost;

            // Print Total purchase charge, number of items purchased,
            Console.WriteLine(" ");
            Console.WriteLine("Your total charge is" + " " + grandTotal.ToString("C"));
            Console.WriteLine(" ");
            Console.WriteLine("You bought" + " " + iCount + " " + " Items with us today!");
            Console.WriteLine(" ");
            Console.WriteLine("Your total sales tax is" + " " + (preTotal * salestax).ToString("C"));
            Console.WriteLine(" ");
            Console.WriteLine("Your Shipping fee is" + " " + shipCost.ToString("C"));
            // sales tax amount, shipping charge, and the grand total

        }
    }
}
