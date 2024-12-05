using System;

namespace Task_7 {
    internal class Program {
        static void Main(string[] args) {

            // decleration of needed variables
            float a;
            float b;
            float c;
            float x;

            // loop to keep the program running as long as the user dosn't exit via ctrl + c
            while (true) {
                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter coefficients A, B, C and the value of X to calculate Y = ax^2 + bx + c"); // explain input demanded
                Console.Write("A: "); // UI aspect of asking for A
                if (!float.TryParse(Console.ReadLine(), out a)) continue; // restart program if given input for A is not parseable
                Console.Write("B: "); // UI aspect of asking for B
                if (!float.TryParse(Console.ReadLine(), out b)) continue; // restart program if given input for B is not parseable
                Console.Write("C: "); // UI aspect of asking for C
                if (!float.TryParse(Console.ReadLine(), out c)) continue; // restart program if given input for C is not parseable
                Console.Write("X: "); // UI aspect of asking for X
                if (!float.TryParse(Console.ReadLine(), out x)) continue; // restart program if given input for X is not parseable

                Console.WriteLine($"The value of Y for the given numbers is: {(a * (x * x)) + (b * x) + c}"); // output result
            }
        }
    }
}
