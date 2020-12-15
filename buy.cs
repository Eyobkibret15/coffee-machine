using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Buying : Remain
    {

        public void buy()
        {
            Program program_object = new Program();
            Console.WriteLine("what do you want to buy?");
            Console.WriteLine("1: espresso");
            Console.WriteLine("2: latte");
            Console.WriteLine("3: capuccino");
            Console.WriteLine("4: back");

            string b_choice = Console.ReadLine();
            if (b_choice == "4" || b_choice == "back") { return; }
            int a_choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount you want");
            if (b_choice == "1")
            {
                if ((Cups >= 1 * a_choice) && (Watter >= 250 * a_choice) && (Coffee_beans >= 16 * a_choice))
                {
                    Cups -= 1 * a_choice;
                    Watter -= 250 * a_choice;
                    Coffee_beans -= 16 * a_choice;
                    Money += 4 * a_choice;
                    Console.WriteLine("total cost = $" + (a_choice * 4).ToString());
                    Console.WriteLine("we are preparing your espresso please wait...");
                }
                else
                {
                    Console.WriteLine("sorry, not enough amount");
                    return;
                }
            }
            else if (b_choice == "2")
            {
                if (Cups >= 1 * a_choice && Watter >= 350 * a_choice && Coffee_beans >= 20 * a_choice && Milk >= 75 * a_choice)
                {
                    Cups -= 1 * a_choice;
                    Watter -= 350 * a_choice;
                    Coffee_beans -= 20 * a_choice;
                    Milk -= 75 * a_choice;
                    Money += 7 * a_choice;
                    Console.WriteLine("total cost = $" + (a_choice * 7).ToString());
                    Console.WriteLine("we are preparing your latte please wait...");
                }
                else
                {
                    Console.WriteLine("sorry, not enough amount");
                    return;
                }
            }
            else if (b_choice == "3")
            {
                if (Cups >= 1 * a_choice && Watter >= 200 * a_choice && Coffee_beans >= 12 * a_choice && Milk >= 100 * a_choice)
                {
                    Cups -= 1 * a_choice;
                    Watter -= 200 * a_choice;
                    Coffee_beans -= 12 * a_choice;
                    Milk -= 100 * a_choice;
                    Money += 6 * a_choice;
                    Console.WriteLine("total cost = $" + (a_choice * 6).ToString());
                    Console.WriteLine("we are preparing your cappuccino please wait...");
                }
                else
                {
                    Console.WriteLine("sorry,not enough amount");
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

