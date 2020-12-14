using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Buying : Program
    {
        public void buy()
        {
            Console.WriteLine("what do you want to buy?");
            Console.WriteLine("1: espresso");
            Console.WriteLine("2: latte");
            Console.WriteLine("3: capuccino");
            Console.WriteLine("4: back");

            string b_choice = Console.ReadLine();
            if (b_choice == "4" || b_choice == "back") { menu(); }
            int a_choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount you want");
            if (b_choice == "1")
            {
                if ((cups >= 1 * a_choice) && (watter >= 250 * a_choice) && (coffee_beans >= 16 * a_choice))
                {
                    cups -= 1 * a_choice;
                    watter -= 250 * a_choice;
                    coffee_beans -= 16 * a_choice;
                    money += 4 * a_choice;
                    Console.WriteLine("total cost = $" + (a_choice * 4).ToString());
                    Console.WriteLine("we are preparing your espresso please wait...");
                }
                else
                {
                    Console.WriteLine("sorry, not enough amount");
                    menu();
                }
            }
            else if (b_choice == "2")
            {
                if (cups >= 1 * a_choice && watter >= 350 * a_choice && coffee_beans >= 20 * a_choice && milk >= 75 * a_choice)
                {
                    cups -= 1 * a_choice;
                    watter -= 350 * a_choice;
                    coffee_beans -= 20 * a_choice;
                    milk -= 75 * a_choice;
                    money += 7 * a_choice;
                    Console.WriteLine("total cost = $" + (a_choice * 7).ToString());
                    Console.WriteLine("we are preparing your latte please wait...");
                }
                else
                {
                    Console.WriteLine("sorry, not enough amount");
                    menu();
                }
            }
            else if (b_choice == "3")
            {
                if (cups >= 1 * a_choice && watter >= 200 * a_choice && coffee_beans >= 12 * a_choice && milk >= 100 * a_choice)
                {
                    cups -= 1 * a_choice;
                    watter -= 200 * a_choice;
                    coffee_beans -= 12 * a_choice;
                    milk -= 100 * a_choice;
                    money += 6 * a_choice;
                    Console.WriteLine("total cost = $" + (a_choice * 6).ToString());
                    Console.WriteLine("we are preparing your cappuccino please wait...");
                }
                else
                {
                    Console.WriteLine("sorry,not enough amount");
                    menu();
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

