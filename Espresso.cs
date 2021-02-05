using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Espresso:Coffee
    {
        
        public void Buy_Espresso()
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

            if ((cups >= 1 * amount_choice) && (watter >= 250 * amount_choice) && (coffee_beans >= 16 * amount_choice))
            {
                    cups -= 1 * amount_choice;
                    watter -= 250 * amount_choice;
                    coffee_beans -= 16 * amount_choice;
                    money += 4 * amount_choice;
                    Console.WriteLine("total cost = $" + amount_choice * 4);
                    Console.WriteLine("we are preparing your espresso please wait...\nyour product is ready");
            }
            else
            {
                    Console.WriteLine("sorry,there is not enough amount please Fill first");
                    return;
            }          
        }
    }
}
