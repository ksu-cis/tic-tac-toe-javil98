using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TicTacToe.Checkers;

namespace TicTacToe.Pages
{
    public class Checker : PageModel
    {
        public Game Game;
        public void OnGet()
        {
            Game = new Game();
        }

        public void OnPost(int checkerX, int checkerY, int squareX, int squareY)
        {
        
            Game = new Game();
            Checkers checker = Game.Board[checkerX, checkerY];
            Game.Board[squareX, squareY] = checker;
            Game.Board[checkerX, checkerY] = null;
        }
    }
}
