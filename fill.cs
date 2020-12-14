using System;
using System.Collections.Generic;
using System.Text;

namespace coffee_machine
{ 
class Filling : Program
{
    public void Fill()
    { 
        Console.WriteLine("write how many of watter do you want to add?");
        watter += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("write how many of milk do you want to add?");
        milk += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("write how many of coffee beans do you want to add?");
        coffee_beans += Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("write how many disposal cups do you want to add?");
        coffee_beans += Convert.ToInt32(Console.ReadLine());
    }

} }
