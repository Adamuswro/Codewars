using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new SnakesLadders();

            do
            {
                System.Console.WriteLine(game.play(2, 2));
            } while (System.Console.ReadLine() != "q");

            System.Console.ReadKey();
        }
    }
}
