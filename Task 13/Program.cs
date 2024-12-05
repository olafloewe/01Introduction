using System;

namespace Task_13 {
    internal class Program {
        static void Main(string[] args) {

            // jagged char array for board
            char[][] field = {
                new char [] { ' ',' ',' ','|',' ',' ',' ','|',' ',' ',' '},
                new char [] { '-','-','-','+','-','-','-','+','-','-','-' },
                new char [] {' ',' ',' ','|',' ',' ',' ','|',' ',' ',' '},
                new char [] {'-','-','-','+','-','-','-','+','-','-','-'},
                new char [] {' ',' ',' ','|',' ',' ',' ','|',' ',' ',' '}
            };
            
            // print board
            for (int i = 0; i < field[i].Length; i++) {
                for (int j = 0; j < field[i].Length; j++) {
                    Console.Write(field[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
