using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    public class TicTokToeGame
    {
        public static char[] Game()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] =' ';
            }
            return board;
        }
        public static char chooseePlayereLetter()
        {
            Console.WriteLine("Choose X or O");
            char letter = char.ToUpper(Console.ReadLine()[0]);
            char computerLetter;
            if(letter.Equals('X')||(letter.Equals('O')))
            {
                if(letter.Equals('X'))
                {
                    computerLetter = 'O';
                }
                else if(letter.Equals('O'))
                {
                    computerLetter = 'X';
                }
            }
            else
            {
                Console.WriteLine("Please choose correct one either X or O");
                
            }
            return letter;
        }
        public static void showBoard(char[] board)
        {
            Console.WriteLine(board[1] + "|" + board[2] + "|" + board[3]);
            Console.WriteLine(board[4] + "|" + board[5] + "|" + board[6]);
            Console.WriteLine(board[7] + "|" + board[8] + "|" + board[9]);
            Console.ReadLine();
        }
    }
}
