using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class SnakeLadder
    {
        internal int PlayerPossition = 0;
        public void Game()
        {  
            Random random = new Random();
            int DieRoll = random.Next(1, 7);
            PlayerPossition = DieRoll;
            Console.WriteLine("Player Position is :"+PlayerPossition);
            Console.ReadLine();
        }
    }
}

