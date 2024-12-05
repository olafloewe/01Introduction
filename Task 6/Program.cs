using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6 {
    internal class Program {
        static void Main(string[] args) {

            float a;
            float b;
            float c;
            float x;

            while (true) {
                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter coefficients A, B, C and the value of X to calculate Y = ax^2 + bx + c");
                Console.Write("A: ");
                if (!float.TryParse(Console.ReadLine(), out a)) continue;
                Console.Write("B: ");
                if (!float.TryParse(Console.ReadLine(), out b)) continue;
                Console.Write("C: ");
                if (!float.TryParse(Console.ReadLine(), out c)) continue;
                Console.Write("X: ");
                if (!float.TryParse(Console.ReadLine(), out x)) continue;

                Console.WriteLine($"The value of Y for the given numbers is: { (a*(x*x)) + (b*x) + c }");
            }
        }
    }
}
