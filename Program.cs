using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Enter the length of the room: ");

            input = Console.ReadLine();
            decimal length = decimal.Parse(input);

            Console.Write("Enter the width of the room: ");
            input = Console.ReadLine();
            decimal width = decimal.Parse(input);

            Console.Write("Enter the overage percent: ");
            input = Console.ReadLine();
            decimal overage = decimal.Parse(input) / 100;

            decimal area = length * width * (1 + overage);
            Console.WriteLine("The total area, including overage, is: " + area.ToString());
        }
    }
}
