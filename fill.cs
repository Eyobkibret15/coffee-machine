using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{
    class Filling : Remain
    {
        public void Fill()
        {
            Console.WriteLine("write how many of watter do you want to add?");
            Watter += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write how many of milk do you want to add?");
            Milk += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write how many of coffee beans do you want to add?");
            Coffee_beans += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write how many disposal cups do you want to add?");
            Cups += Convert.ToInt32(Console.ReadLine());
        }

    }
}
