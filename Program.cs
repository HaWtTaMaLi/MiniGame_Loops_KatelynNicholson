using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame_Loops_KatelynNicholson
{
    internal class Program
    {

        static int playerPosition = 0;
        static bool gameOver = false;

        static void Main()
        {
            //move player using WASD
            

            //have a trail follow player
            //if player exits pannel. you loose
            //hit escape to exit
            //keep trail visable and if player lands on a spot already marked then. you loose//visited
            //array playable area
        }


        static void PlayerDraw(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(5, 2);
            Console.WriteLine("^ ^");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=[0.0]=");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void PlayerUpdate(int x,int y)
        {
            //console.readkey()
            //console.keyinfor.keychar
        }
    }
}
