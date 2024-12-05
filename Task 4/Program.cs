using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4 {
    internal class Program {
        static void Main(string[] args) {

            float conversion = 4.06F;

            float pln = 20;
            float usd = (float)Math.Round((pln / conversion), 2);
            
            Console.WriteLine($"USD: {usd} from PLN: {pln}");
            
        }
    }
}
