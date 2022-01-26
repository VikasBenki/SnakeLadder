using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake and ladder problem");
            
            SnakeAndLadder Player = new SnakeAndLadder();
            Player.playGame();
            Console.ReadKey();
        }
    }
}
