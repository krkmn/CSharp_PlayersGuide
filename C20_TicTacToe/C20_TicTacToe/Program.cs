using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C20_TicTacToe
{
    class Program
    {
        static char next_move_char(int move)
        {
            if ((move + 1) % 2 == 1)
                return 'X';
            else
                return 'O';
        }

        static void draw_board(char[] moves)
        {
            Console.WriteLine($" {moves[0]} | {moves[1]} | {moves[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {moves[3]} | {moves[4]} | {moves[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {moves[6]} | {moves[7]} | {moves[8]} ");
        }

        static bool already_marked(int[] move_marked, int next_move)
        {
            foreach (int item in move_marked)
            {
                if (item == next_move)
                    return true;
            }
            return false;
        }

        static bool row_check(int[] mark_list)
        {
            if (mark_list.Length < 3)
                return false;
            int[,] winners = new int[,] { { 0, 1, 2 }, { 0, 4, 8 }, { 0, 3, 6 }, { 3, 4, 5 }, { 1, 4, 7 }, { 2, 5, 8 }, { 2, 4, 6 } };

            for (int i = 0; i < 7; i++)
            {
                int match = 0;

                for (int j = 0; j < 3; j++)
                {
                    foreach (int items in mark_list)
                    {
                        if (winners[i, j] == items)
                            ++match;
                    }
                }
                if (match == 3)
                    return true;
            }
            return false;
        }



        static void Main(string[] args)
        {
            char[] move = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
            int[] move_marked = new int[9] { -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] x_marked = new int[9];
            int[] o_marked = new int[9];
            char move_char;
            int next_move_place;

            int x_fill = 0;
            int o_fill = 0;

            draw_board(move);

            for (int i=0; i<9; i++)
            {
                move_char = next_move_char(i);


                bool in_list_already = true;
                
                while (in_list_already == true)
                {
                    Console.WriteLine($"Where should the next {move_char} be placed?");
                    next_move_place = Convert.ToInt32(Console.ReadLine());

                    in_list_already = already_marked(move_marked, next_move_place);
                    if (in_list_already == true)
                        Console.WriteLine("Place was already occupied");
                    else
                        move_marked[i] = next_move_place;
                }
                next_move_place = move_marked[i];

                if (move_char == 'X')
                {
                    x_fill += ( next_move_place);
                    move[next_move_place] = 'X';
                    x_marked[i] = next_move_place;
                    draw_board(move);

                    bool win = row_check(x_marked);

                    if (win == true)
                    {
                        Console.WriteLine("X wins!!!");
                        break;
                    }
                }
                else
                {
                    o_fill += (next_move_place);
                    move[next_move_place] = 'O';
                    o_marked[i] = next_move_place;
                    draw_board(move);

                    bool win = row_check(o_marked);

                    if (win == true)
                    {
                        Console.WriteLine("O wins!!!");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
