using KataSolutions;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new kyu5_Snakes_and_Ladders();

            do
            {
                System.Console.WriteLine(game.play(2, 2));
            } while (System.Console.ReadLine() != "q");

            System.Console.ReadKey();
        }
    }
}
