using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lyserra.Game.Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameLoop gameLoop = new GameLoop();

            gameLoop.startGame();
        }
    }
}
