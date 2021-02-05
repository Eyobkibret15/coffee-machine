/*using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Filling : Remain
    {
        public void Fill()
        {
            int fill_watter = -1;
            int fill_milk = -1;
            int fill_coffeebeans = -1;
            int fill_cups = -1;

            while (fill_watter < 0)
            {
                try
                {
                    Console.WriteLine("write how many of watter do you want to add?");
                    fill_watter = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please enter valid number");
                }
            }
            while (fill_milk < 0)
            {
                try
                {
                    Console.WriteLine("write how many of milk do you want to add?");
                    fill_milk = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please enter valid number");
                }
            }

            while (fill_coffeebeans < 0)
            {
                try
                {
                    Console.WriteLine("write how many of coffee beans do you want to add?");
                    fill_coffeebeans = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please enter valid number");
                }
            }
            while (fill_cups < 0)
            {
                try
                {
                    Console.WriteLine("write how many of cups do you want to add?");
                    fill_cups = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please enter valid number");
                }
            }
            Watter += fill_watter;
            Milk += fill_milk;
            Coffee_beans += fill_coffeebeans;
            Cups += fill_cups;
        }

    }

}

*/