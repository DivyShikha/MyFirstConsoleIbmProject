using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class Loops
    {
        //for loop
        public void ForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }
        }
        //while loop
        public void WhileLoopExample()
        {
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"While loop iteration {j}");
                j++;
            }
        }

        //do while loop
        public void DoWHileExample()
        {
            int k = 0;
            do
            {
                Console.WriteLine($"Do-While loop Iteration {k}");
                k++;
                
            }
            while (k < 4);
        }
        //foreach loop
        public void ForEachExample()
        {
            string[] names = { "ALice", "Bob", "Divy" };
            foreach(string name in names)
            {
                Console.WriteLine($"Hello {name}");
            }
        }
    }
}
