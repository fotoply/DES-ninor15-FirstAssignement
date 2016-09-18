using System;

namespace DES_ninor15
{
    public class TestClasses
    {
        static void Main(String[] args)
        {
            Task6.Task6 task6 = new Task6.Task6();

            Task7.Task7 task7 = new Task7.Task7();

            Task8.Task8 task8 = new Task8.Task8();

            Task9.Task9 task9 = new Task9.Task9();
            string line;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Type task6 for task 6, task7 for task 7, etc and q to quit");
                line = Console.ReadLine();
                switch (line)
                {
                    case "task6":
                        Console.WriteLine("Enter string for reversal:");
                        task6.TestString(Console.ReadLine());
                        break;

                    case "task7":
                        Console.WriteLine("Enter name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter drink: ");
                        string drink = Console.ReadLine();
                        task7.OrderDrink(name, drink);
                        break;

                    case "task8":
                        Console.WriteLine("Playing tennis!");
                        task8.Main();
                        break;

                    case "task9":
                        Console.WriteLine("Enter size: ");
                        int size = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter times to tick: ");
                        int ticks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Playing conways:");
                        task9.CreateGrid(size, size, ticks);

                        break;

                    default:
                        Console.WriteLine("Invalid option (" + line + ")");
                        break;
                }

            } while (line != "q");
        }
    }
}