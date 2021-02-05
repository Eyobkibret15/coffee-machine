using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Capuccino:Coffee
    {
        public void Buy_Capuccino()
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

            if ((cups >= 1 * amount_choice )&& (watter >= 200 * amount_choice) && (coffee_beans >= 12 * amount_choice) && (milk >= 100 * amount_choice))
            {

                cups -= 1 * amount_choice;
                watter -= 200 * amount_choice;
                coffee_beans -= 12 * amount_choice;
                milk -= 100 * amount_choice;
                money += 6 * amount_choice;
                Console.WriteLine("total cost = $" + (amount_choice * 6).ToString());
                Console.WriteLine("we are preparing your espresso please wait...\nyour product is ready");
            }
            else
            {
                Console.WriteLine("sorry,there is not enough amount please Fill first");
                return ;
            }
        }       
    }
}
