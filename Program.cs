using System;

namespace coffee_machine
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Remain base_object = new Remain();
                Console.WriteLine("menu");
                Console.WriteLine("1: buy");
                Console.WriteLine("2: fill");
                Console.WriteLine("3: take");
                Console.WriteLine("4: remaing");
                Console.WriteLine("5: exit");
                Console.WriteLine("enter you choice");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Buying obj_buy = new Buying();
                        obj_buy.buy();
                        break;
                    case "2":
                        Filling obj_fill = new Filling();
                        obj_fill.Fill();
                        break;
                    case "3":
                        Console.WriteLine("i gave you $" + base_object.Money.ToString());
                        break;
                    case "4":
                        Remain obj_rm = new Remain();
                        obj_rm.remaining();
                        break;
                    case "5":
                        Console.WriteLine("the program is finished");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("invalid choice please try again");
                        break;
                }
            }
        }
    }



}


