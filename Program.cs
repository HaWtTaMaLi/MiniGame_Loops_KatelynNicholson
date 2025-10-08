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
        static bool[,] visited = new bool [x,y];

        static void Main()
        {

            Console.CursonrVisable = false;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            for (int y = 0; y < 20; y++)
            {
                for(int x = 0; x < 20; x++)
                {
                    playArea[y, x] = true;
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            //playerPosition = //x and y
            //move player using WASD
            x = 3;
            y = 3;
            char player = 'O';
            visited[y, x] = true;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(x, y);

            while (!gameOver)
            {

                ConsoleKey = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.W:
                        if (y > 0) y--;
                        break;
                    case ConsoleKey.S:
                        if (y < 19) y++;
                        break;
                    case ConsoleKey.A:
                        if (x > 0) x--;
                        break;
                    case ConsoleKey.D:
                        if (x 19) x++;
                        break;
                    case ConsoleKey.Escape: //hit escape to exit
                        return;
                }

                if (visited[y, x])
                { 
                    gameOver = true;
                    Console.Clear();
                    Console.WriteLine("You stepped on a visited tile! GameOver!");
                    break;
                }

                    visited[y, x] = true;

                //if player exits pannel. you loose
                //array playable area
            }
        }
    }
}
