using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12 {
    internal class Program {
        static void Main(string[] args) {
            int hei = 3;
            int wid = 5;

            for (int i = 0; i < hei; i++) {
                for (int j = 0; j < wid; j++) {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
