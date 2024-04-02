using System;

namespace Conversion3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            char choice = 'Y';
            while (choice == 'Y' || choice == 'y')
            {
                Console.WriteLine("Choose:");
                Console.WriteLine("1. Seconds to Minutes");
                Console.WriteLine("2. Minutes to Hours");
                Console.WriteLine("3. Hours to Days");
                Console.WriteLine("4. Days to Months");

                int option;
                Console.Write("Enter your choice (1/2/3/4): ");
                option = int.Parse(Console.ReadLine());

                double input;
                Console.Write("Enter the value to convert: ");
                input = double.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Minutes: " + input / 60);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Hours: " + input / 60);
                }
                else if (option == 3)
                {
                    Console.WriteLine("Days: " + input / 24);
                }
                else if (option == 4)
                {
                    Console.WriteLine("Months: " + input / 30);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }

                Console.Write("Do you want to convert again? (Y/N): ");
                choice = Console.ReadLine()[0];
            }
        }
    }
}
