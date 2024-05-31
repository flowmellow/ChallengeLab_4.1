/*
Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
The customer id., name and unit consumed by the user should be taken from the user and display the total amount to pay to the customer. 
The charge are as follows: (you may change the charge sheet values)

Unit Charge/unit
upto 199 @1.20
200 and above but less than 400 @1.50
400 and above but less than 600 @1.80
600 and above @2.00
If bill exceeds $ 400 then a surcharge of 15% will be charged.

Test Data : 1001
James: 800
Expected Output :
Customer IDNO :1001
Customer Name :James
unit Consumed :800
Amount Charges @$ 2.00 per unit : 1600.00
Surcharge Amount : 240.00
Net Amount Paid By the Customer : 1840.00
*/

using System.Transactions;

namespace ChallengeLab_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double unitsConsumed = 350;
            TierMaxCost tier = new TierMaxCost();

            Console.WriteLine("Enter customer ID: ");
            string customerID = Console.ReadLine();
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Customer ID: {customerID}");
            Console.WriteLine($"Customer Name: {firstName}");
            Console.WriteLine($"Units consumed; {unitsConsumed}");

            switch (unitsConsumed) 
           {    
                case >=0 and <=199:
                    double tier120 = unitsConsumed * 1.2;
                    double total1 = tier120;
                    Console.WriteLine($"Net Amount Paid By the Customer: ${total1}");
                    break;
                case >= 200 and <= 399:
                    double tier150 = (unitsConsumed - 199) * 1.5;
                    double total2 = tier.Tier120Max() + tier150;
                    if (total2 >= 400)
                    {
                        double surcharge1 = total2 * .15;
                        double totalWithSurcharge = total2 + surcharge1;
                        Console.WriteLine($"Amount charged for unit usage: ${total2}");
                        Console.WriteLine($"Surcharge Amount: ${surcharge1}");
                        Console.WriteLine($"Net Amount Paid By the Customer: ${totalWithSurcharge}");
                    }
                    else
                    {
                        Console.WriteLine($"Net Amount Paid By the Customer: ${total2}");                  
                    }
                    break;
                case >= 400 and <= 599:
                    double tier180 = (unitsConsumed - 399) * 1.8;            
                    double total3 = tier.Tier120Max() + tier.Tier150Max() + tier180;
                    double surcharge2 = total3 * .15;
                    double totalWithSurcharge2 = total3 + surcharge2;
                    Console.WriteLine($"Amount charged for unit usage: ${total3}");
                    Console.WriteLine($"Surcharge Amount: ${surcharge2}");
                    Console.WriteLine($"Net Amount Paid By the Customer: ${totalWithSurcharge2}");
                    break;
                case >= 600:
                    double tier200 = (unitsConsumed - 599) * 2;
                    double total4 = tier.Tier120Max() + tier.Tier150Max() + tier.Tier180Max() + tier200;
                    double surcharge3 = total4 * .15;
                    double totalWithSurcharge3 = total4 + surcharge3;
                    Console.WriteLine($"Amount charged for unit usage: ${total4}");
                    Console.WriteLine($"Surcharge Amount: ${surcharge3}");
                    Console.WriteLine($"Net Amount Paid By the Customer: ${totalWithSurcharge3}");
                    break;

            }    
            
        }

        class TierMaxCost
        {
            public double Tier120Max()
            {
                double tier120Max = 199 * 1.2;
                return tier120Max;
            }

            public double Tier150Max()
            {
                double tier150Max = 200 * 1.5; 
                return tier150Max;
            }

            public double Tier180Max()
            {
                double tier180Max = 200 * 1.8;
                return tier180Max;
            }

            


        }
    }
}
