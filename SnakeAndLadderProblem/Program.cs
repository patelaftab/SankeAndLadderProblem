using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SnakeLadder snakeLadder=new SnakeLadder();
            Console.WriteLine("Player Position :" +snakeLadder.PlayerPossition);
            snakeLadder.PlayingTillWin();
            snakeLadder.Game();
            Console.ReadLine();
        }
    }
}
