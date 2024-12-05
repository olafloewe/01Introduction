using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11 {
    internal class Program {
        static void Main(string[] args) {

            float num;

            while (true) {
                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter number with a decimal value"); 
                Console.Write("Number: "); 
                if (!float.TryParse(Console.ReadLine(), out num)) continue; 

                Console.WriteLine($"Your number as an integer: {(int)num}");
            }
        }
    }
}
