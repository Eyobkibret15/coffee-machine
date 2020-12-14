using System;

namespace coffee_machine
{
    class Program
    {
        public static int watter = 500;
        public static int milk = 540;
        public static int coffee_beans = 120;
        public static int cups = 9;
        public static int money = 550;
        static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
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
                case  "1":
                    Buying obj_buy = new Buying();
                    obj_buy.buy();
                    break;
                case "2" :
                    Filling obj_fill = new Filling();
                    obj_fill.Fill();
                    break;
                case "3":
                    Console.WriteLine("i gave you $" + money.ToString());
                    break;
                case "4":
                    Remain obj_rm = new Remain();
                    obj_rm.remaining();
                    break;
                case "5":
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("invalid choice please try again");
                    menu();
                    break;
            }

            if (choice == "1" || choice =="2"||choice =="3"||choice=="4")
                    {
                menu();
            }

        }
        }



    }


