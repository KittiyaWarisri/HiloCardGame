using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiloCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Games play = new Games();
            play.PlayGame();
            Console.ReadLine();
        }
    }
}
