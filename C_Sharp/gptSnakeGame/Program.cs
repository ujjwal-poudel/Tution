using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Set up game variables
        int width = 1;
        int height = 1;
        int x = width / 2;
        int y = height / 2;
        int score = 0;
        Random rand = new Random();
        List<int> snakeX = new List<int> { x };
        List<int> snakeY = new List<int> { y };
        int foodX = rand.Next(0, width);
        int foodY = rand.Next(0, height);
        ConsoleKeyInfo key;
        bool gameover = false;

        // Set up initial game display
        Console.Clear();
        Console.CursorVisible = false;
        Console.SetCursorPosition(foodX, foodY);
        Console.Write("*");
        Console.SetCursorPosition(x, y);
        Console.Write("O");

        // Main game loop
        while (!gameover)
        {
            // Check for user input
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                }
            }

            // Check for collisions
            if (x < 0 || x >= width || y < 0 || y >= height ||
                snakeX.Contains(x) && snakeY.Contains(y))
            {
                gameover = true;
                Console.SetCursorPosition(width / 2 - 4, height / 2);
                Console.Write("Game Over!");
                Thread.Sleep(2000);
            }

            // Check for food
            if (x == foodX && y == foodY)
            {
                score++;
                Console.SetCursorPosition(width / 2 - 4, 0);
                Console.Write($"Score: {score}");
                foodX = rand.Next(0, width);
                foodY = rand.Next(0, height);
                Console.SetCursorPosition(foodX, foodY);
                Console.Write("*");
            }

            // Update snake position
            snakeX.Insert(0, x);
            snakeY.Insert(0, y);
            Console.SetCursorPosition(snakeX.Last(), snakeY.Last());
            Console.Write(" ");
            snakeX.RemoveAt(snakeX.Count - 1);
            snakeY.RemoveAt(snakeY.Count - 1);
            Console.SetCursorPosition(x, y);
            Console.Write("O");

            // Wait before next frame
            Thread.Sleep(100);
        }
    }
}