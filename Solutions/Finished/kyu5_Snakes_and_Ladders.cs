using System;
using System.Collections.Generic;

namespace KataSolutions
{
    public class kyu5_Snakes_and_Ladders
    {
        Player currentPlayer;
        List<Player> players;

        Dictionary<int, int> LeddersAndSnakes = new Dictionary<int, int> { { 2, 38 }, { 7, 14 }, { 8, 31 }, { 15, 26 }, { 28, 84 }, { 21, 42 }, { 36, 44 }, { 51, 67 }, { 71, 91 }, { 78, 98 }, { 87, 94 }, { 99, 80 }, { 95, 75 }, { 92, 88 }, { 89, 68 }, { 74, 53 }, { 62, 19 }, { 64, 60 }, { 46, 25 }, { 49, 11 }, { 16, 6 } };

        bool isGameOver = false;

        public kyu5_Snakes_and_Ladders()
        {
            players = new List<Player>()
            {
                new Player(){SquareNumber=0, Name="Player 1" },
                new Player(){SquareNumber=0, Name="Player 2" }
            };

            currentPlayer = players[0];
        }

        public string play(int die1, int die2)
        {
            var currentPlayer = this.currentPlayer;
            if (isGameOver)
            {
                return "Game over!";
            }

            int newSquare = die1 + die2 + currentPlayer.SquareNumber;
            newSquare -= Math.Max(2 * (newSquare - 100), 0);

            if (newSquare == 100)
            {
                isGameOver = true;
                return $"{currentPlayer.Name} Wins!";
            }

            if (LeddersAndSnakes.ContainsKey(newSquare))
            {
                currentPlayer.SquareNumber = LeddersAndSnakes[newSquare];
            }
            else
            {
                currentPlayer.SquareNumber = newSquare;
            }

            if (die1 == die2 && currentPlayer.IsExtraTurn == false)
            {
                currentPlayer.IsExtraTurn = true;
            }
            else
            {
                currentPlayer.IsExtraTurn = false;
                SwitchPlayer();
            }

            return $"{currentPlayer.Name} is on square {currentPlayer.SquareNumber}";
        }

        private void SwitchPlayer()
        {
            var currentIndex = players.IndexOf(currentPlayer);
            if (currentIndex == players.Count - 1)
            {
                currentPlayer = players[0];
                return;
            }

            currentPlayer = players[++currentIndex];
        }
    }

    class Player
    {
        public int SquareNumber { get; set; }
        public string Name { get; set; }
        public bool IsExtraTurn { get; internal set; } = false;
    }
}
