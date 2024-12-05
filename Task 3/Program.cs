using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3 {
    internal class Program {
        static void Main(string[] args) {


                /*
                Errors during compilation:

                line 1 missing ;
                line 2 no type for y
                line 4 trying to redefine already used variable name and trying to define int as a string return

                Errors during execution:

                line 6 cant divide by 0
                */


                int x = 5;
                int y = 0;

                y = int.Parse(Console.ReadLine()); // to not divide by 0

                Console.WriteLine(x / y); 

        }
    }
}
