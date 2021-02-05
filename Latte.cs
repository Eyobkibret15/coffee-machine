using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Latte:Coffee
    {
        public  void Buy_Latte()
        {
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
            if (cups >= 1 * amount_choice && watter >= 350 * amount_choice && coffee_beans >= 20 * amount_choice && milk >= 75 * amount_choice)
            {
                cups -= 1 * amount_choice;
                watter -= 350 * amount_choice;
                coffee_beans -= 20 * amount_choice;
                milk -= 75 * amount_choice;
                money += 7 * amount_choice;
                Console.WriteLine("total cost = $" + (amount_choice * 7).ToString());
                Console.WriteLine("we are preparing your latte please wait...\nyour product is ready");
            }
            else
            {
                Console.WriteLine("sorry,there is not enough amount please Fill first");
                return ;
            }
        }
    }
}
