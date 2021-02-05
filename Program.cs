using System;

namespace coffee_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee_obj = new Coffee();
            Espresso espresso_obj = new Espresso();
            Latte latte_obj = new Latte();
            Capuccino capuccino_obj = new Capuccino();

            coffee_obj.Intial_Value();
            while (true)
            {
  
                Console.WriteLine("Menu");
                Console.WriteLine("1: Buy");
                Console.WriteLine("2: Fill");
                Console.WriteLine("3: Take");
                Console.WriteLine("4: Remaing");
                Console.WriteLine("5: Exit");
                Console.WriteLine("Enter you choice");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        string b_choice = coffee_obj.Buy();
                        if (b_choice=="1")
                        {
                            espresso_obj.Buy_Espresso();
                        }
                        else if (b_choice == "2")
                        {
                            latte_obj.Buy_Latte();
                        }
                        else if (b_choice == "3")
                        {
                            capuccino_obj.Buy_Capuccino();
                        }
                        break;
                    case "2":
                        coffee_obj.Fill();
                        break;
                    case "3":
                        coffee_obj.Take();
                        break;
                    case "4":
                        coffee_obj.Remaining();
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