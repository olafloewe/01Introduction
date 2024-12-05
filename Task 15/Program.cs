using System;
using System.IO;
using System.Security.Cryptography;

namespace Task_15 {
    internal class Program {
        static void Main(string[] args) {

            while (true) {
                bool err = false;
                char[] gameState = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', };

                // getting user input and guardian clauses for miss input
                Console.WriteLine("Welcome to tic-tac-toe: ");

                // ask for user input for gamestate
                for (int i = 0; i < gameState.Length; i++) {
                    Console.Write($"What's the state ('X','O' or ' ') of the field {i+1}: ");
                    gameState[i] = Console.ReadKey().KeyChar; // read gamestate input
                    Console.WriteLine();

                    // fail if invalid input
                    if (gameState[i] != ' ' && gameState[i] != 'X' && gameState[i] != 'O') {
                        err = true;
                        break;
                    }
                }
                if (err) continue; // restart on err

                // jagged char array for board
                char[][] field = {
                    new char [] { ' ', gameState[0],' ','|',' ', gameState[1], ' ','|',' ', gameState[2], ' '},
                    new char [] { '-','-','-','+','-','-','-','+','-','-','-' },
                    new char [] {' ', gameState[3], ' ','|',' ', gameState[4], ' ','|',' ', gameState[5], ' '},
                    new char [] {'-','-','-','+','-','-','-','+','-','-','-'},
                    new char [] {' ', gameState[6], ' ','|',' ', gameState[7], ' ','|',' ', gameState[8], ' '}
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
}