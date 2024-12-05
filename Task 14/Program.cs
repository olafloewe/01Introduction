using System;

namespace Task_14 {
    internal class Program {
        static void Main(string[] args) {

            char one = ' ';
            char two = 'O';
            char three = ' ';
            char four = 'O';
            char five = ' ';
            char six = ' ';
            char seven = 'X';
            char eight = 'X';
            char nine = 'X';

            // jagged char array for board
            char[][] field = {
                new char [] { ' ',one,' ','|',' ',two,' ','|',' ',three,' '},
                new char [] { '-','-','-','+','-','-','-','+','-','-','-' },
                new char [] {' ',four,' ','|',' ',five,' ','|',' ',six,' '},
                new char [] {'-','-','-','+','-','-','-','+','-','-','-'},
                new char [] {' ',seven,' ','|',' ',eight,' ','|',' ',nine,' '}
            };

            // print board
            for (int i = 0; i < field.Length; i++) {
                for (int j = 0; j < field[i].Length; j++) {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
