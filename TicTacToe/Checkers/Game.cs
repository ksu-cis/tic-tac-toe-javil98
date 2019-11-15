using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Checkers
{
    public class Game
    {
        public Color Turn = Color.Red;

        public Checkers[,] Board = new Checkers[8, 8];
        
        public Game()
        {
            for(int i = 0; i < 8; i += 2)
            {
                Board[i, 0] = new Checkers(Color.Black);
                Board[i + 1, 1] = new Checkers(Color.Black);
                Board[i, 2] = new Checkers(Color.Black);

                Board[i, 5] = new Checkers(Color.Red);
                Board[i + 1, 6] = new Checkers(Color.Red);
                Board[i, 7] = new Checkers(Color.Red);
            }
        }

        public string Serialize()
        {
            string state = Turn.ToString();

            for(int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (Board[x, y] != null)
                    {
                        Checkers checker = Board[x, y];
                        state += $"\n";
                    }
                }
        }
    }
} 
