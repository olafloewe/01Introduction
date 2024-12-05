using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5 {
    internal class Program {
        static void Main(string[] args) {

            float conversion = 4.06F;
            float pln;

            while (true) {
                // getting user input and guardian clauses for miss input
                Console.WriteLine("Enter PLN to be converted to USD: ");
                Console.Write("PLN: ");
                if (!float.TryParse(Console.ReadLine(), out pln)) continue;

                float usd = (float)Math.Round((pln / conversion), 2);

                Console.WriteLine($"USD: {usd} from PLN: {pln}");
            }
        }
    }
}
