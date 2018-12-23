﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_TicTacToe_redo
{
    public class Renderer
    {
        public void Render(Board board)
        {
            char[,] symbols = new char[3, 3];
            for (int row = 0; row < 3; row++)
                for (int column = 0; column < 3; column++)
                    symbols[row, column] = SymbolFor(board.GetState(new Position(row, column)));

            Console.WriteLine($" {symbols[0,0]} | {symbols[0, 1]} | {symbols[0, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]} ");
        }

        private char SymbolFor(State state)
        {
            if (state == State.X) return 'X';
            if (state == State.O) return 'O';
            return ' ';
        }

        public void RenderResults(State winner)
        {
            switch (winner)
            {
                case State.O:
                case State.X:
                    Console.WriteLine($"The winner is {SymbolFor(winner)}!");
                    break;
                case State.Undecided:
                    Console.WriteLine("Draw!");
                    break;
            }
        }



    }
}
