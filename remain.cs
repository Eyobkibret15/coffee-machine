using System;
namespace coffee_machine
{
    class Remain
    {
        private static int watter = 500;
        private static int milk = 540;
        private static int coffee_beans = 120;
        private static int cups = 9;
        private static int money = 550;

        public int Watter
        {
            get { return watter; }
            set { watter = value; }
        }
        public int Milk
        {
            get { return milk; }
            set { milk = value; }
        }
        public int Coffee_beans
        {
            get { return coffee_beans; }
            set { coffee_beans = value; }
        }
        public int Cups
        {
            get { return cups; }
            set { cups = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public void remaining()
        {
            Console.WriteLine("the coffee machine has");
            Console.WriteLine(watter + " of watter");
            Console.WriteLine(milk + " of milk");
            Console.WriteLine(coffee_beans + " of coffee beans");
            Console.WriteLine(cups + " of watter");
            Console.WriteLine("$" + money + " of money");
        }


    }
}