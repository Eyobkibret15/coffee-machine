using System;

namespace coffee_machine
{
    class Coffee
    {
        protected static  double watter { get; set; }
        protected static double milk { get; set; }
        protected static double coffee_beans { get; set; }
        protected static double cups { get; set; }
        protected static double money;
        protected static string b_choice { get; set; }

        public void Intial_Value()
        {
            watter = 400;
            milk = 540;
            coffee_beans = 120;
            cups = 9;
            money = 550;
        }
        public string Buy()
        {
            Console.WriteLine("item lists\n1: Espresso");
            Console.WriteLine("2: Latte");
            Console.WriteLine("3: Capuccino");
            Console.WriteLine("4: Back");
            Console.WriteLine("Enter the number you want to buy?");
            b_choice = Console.ReadLine();
            if (b_choice == "4") { return "0"; }

            if(b_choice != "1" && b_choice != "2" && b_choice != "3" && b_choice != "4")
            {
                Console.WriteLine("invalid choice please try again ");
                Buy();
            }
            return b_choice;
        }

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
                    Console.WriteLine("write how many of watter do you want to add? if you don't want to add please enter 0!");
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
                    Console.WriteLine("write how many of watter do you want to add? if you don't want to add please enter 0!");
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
                    Console.WriteLine("write how many of watter do you want to add? if you don't want to add please enter 0!");
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
                    Console.WriteLine("write how many of watter do you want to add? if you don't want to add please enter 0");
                    fill_cups = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("please enter valid number");
                }
            }
            watter += fill_watter;
            milk += fill_milk;
            coffee_beans += fill_coffeebeans;
            cups += fill_cups;
            Console.WriteLine("you have sucessfully added all row materials");
        }
        public void Remaining()
        {
            Console.WriteLine("The coffee machine has");
            Console.WriteLine("Watter = "+ watter + " ml" );
            Console.WriteLine("Milk = "+milk + " ml");
            Console.WriteLine("Coffee beans = " + coffee_beans + " g");
            Console.WriteLine("Cups = "+ cups);
            Console.WriteLine("Money = " +"$" + money );
        }
        public void Take()
        {
            Console.WriteLine("you have $" + money);
            double take = -1;
            while (take < 0)
            {
                try
                {
                    take = Convert.ToInt32(Console.ReadLine());
                    if(take <= money)
                    {
                        money -= take;
                        Console.WriteLine("Take  $" + take);
                    }
                    else
                    {
                        Console.WriteLine("you don't have enough money.\nPlease try less amount");
                        take = -1;
                    }

                }
                catch
                {
                    Console.WriteLine("please enter valid number ");
                }
            }
        }
    }
}
