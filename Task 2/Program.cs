using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2 {
    internal class Program {
        static void Main(string[] args) {


            float hei;
            float wid;

            while (true) {

                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter the height and width of a rectangle to calculate its area: ");
                Console.Write("height: ");
                if (!float.TryParse(Console.ReadLine(), out hei)) continue;
                Console.Write("width: ");
                if (!float.TryParse(Console.ReadLine(), out wid)) continue;

                Console.WriteLine($"Rectangle area: {wid*hei}");
            }

        }
    }
}
