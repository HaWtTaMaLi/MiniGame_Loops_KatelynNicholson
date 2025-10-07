using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame_Loops_KatelynNicholson
{
    internal class Program
    {
  
        static int playerPosition;
        static bool gameOver = false;
        static int x;
        static int y;

        static bool[,] playArea = new bool [20,20];

        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            for (int y = 0; y < 20; y++)
            {
                for(int x = 0; x < 20; x++)
                {
                    playArea[y, x] = true;
                    if (playArea[y, x])
                        Console.Write("  ");
                    else
                        gameOver = true;
                }
                Console.WriteLine();
            }

            //playerPosition = //x and y
            //move player using WASD
            x = 3;
            y = 3;
            char player = 'O';

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(x, y);
                Console.Write($"=[{player}.O]=");
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.W:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.S:
                        if (y < Console.WindowHeight - 1) y++;
                        break;
                    case ConsoleKey.A:
                        if (x > 0) x--;
                        break;
                    case ConsoleKey.D:
                        if (x < Console.WindowWidth - 1) x++;
                        break;
                    case ConsoleKey.Escape: //hit escape to exit
                        return;
                }
                //if player exits pannel. you loose
                //array playable area
            }
        }
        static  void PlayerDraw(int x, int y)
        {

        }

    }
}
