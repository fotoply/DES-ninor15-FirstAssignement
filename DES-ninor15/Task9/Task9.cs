using System;

namespace DES_ninor15.Task9
{
    public class Task9
    {
        private ConwaysGrid grid;

        public void CreateGrid(int width, int height, int ticks)
        {
            grid = new ConwaysGrid(width, height);
            grid.InitializeRandomState();
            Console.WriteLine("Initial: ");
            Console.Write(grid.ToString());
            Console.WriteLine();

            for (int i = 0; i < ticks; i++)
            {
                grid.Tick();
                Console.WriteLine("Iteration " + i + ":");
                Console.Write(grid.ToString());
                Console.WriteLine();
            }
        }

        public void Main()
        {
            grid = new ConwaysGrid(10, 10);
            grid.InitializeRandomState();
            Console.WriteLine("Initial state:");
            Console.Write(grid.ToString());
            Console.WriteLine();

            grid.Tick();
            Console.WriteLine("Ticked once:");
            Console.Write(grid.ToString());
        }
    }
}