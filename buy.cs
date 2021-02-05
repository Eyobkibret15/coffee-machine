/*using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Buying : Remain
    {

        public void buy()
        {
            Program program_object = new Program();
            Console.WriteLine("item lists\n1: espresso");
            Console.WriteLine("2: latte");
            Console.WriteLine("3: capuccino");
            Console.WriteLine("4: back");
            Console.WriteLine("enter the number you want to buy?");
            string b_choice = Console.ReadLine();
            if (b_choice == "4") { return; }
            int amount_choice = 0;
            while (amount_choice <= 0)
            {
                try
                {
                    Console.WriteLine("enter the quantity of the product");
                    amount_choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please enter number greter than zero only");
                }

            }
            if (b_choice == "1")
            {
                if ((Cups >= 1 * amount_choice) && (Watter >= 250 * amount_choice) && (Coffee_beans >= 16 * amount_choice))
                {
                    Cups -= 1 * amount_choice;
                    Watter -= 250 * amount_choice;
                    Coffee_beans -= 16 * amount_choice;
                    Money += 4 * amount_choice;
                    Console.WriteLine("total cost = $" + (amount_choice * 4).ToString());
                    Console.WriteLine("we are preparing your espresso please wait...\nyour product is ready");
                }
                else
                {
                    Console.WriteLine("sorry,there is not enough amount");
                    return;
                }
            }
            else if (b_choice == "2")
            {
                if (Cups >= 1 * amount_choice && Watter >= 350 * amount_choice && Coffee_beans >= 20 * amount_choice && Milk >= 75 * amount_choice)
                {
                    Cups -= 1 * amount_choice;
                    Watter -= 350 * amount_choice;
                    Coffee_beans -= 20 * amount_choice;
                    Milk -= 75 * amount_choice;
                    Money += 7 * amount_choice;
                    Console.WriteLine("total cost = $" + (amount_choice * 7).ToString());
                    Console.WriteLine("we are preparing your latte please wait...\nyour product is ready");
                }
                else
                {
                    Console.WriteLine("sorry,there is not enough amount");
                    return;
                }
            }

            else if (b_choice == "3")
            {
                if (Cups >= 1 * amount_choice && Watter >= 200 * amount_choice && Coffee_beans >= 12 * amount_choice && Milk >= 100 * amount_choice)
                {
                    Cups -= 1 * amount_choice;
                    Watter -= 200 * amount_choice;
                    Coffee_beans -= 12 * amount_choice;
                    Milk -= 100 * amount_choice;
                    Money += 6 * amount_choice;
                    Console.WriteLine("total cost = $" + (amount_choice * 6).ToString());
                    Console.WriteLine("we are preparing your espresso please wait...\nyour product is ready");
                }
                else
                {
                    Console.WriteLine("sorry,there is not enough amount");
                    return;
                }
            }

            else
            {
                Console.WriteLine("invalid choice please try again ");
                buy();
            }

        }
    }
}

*/