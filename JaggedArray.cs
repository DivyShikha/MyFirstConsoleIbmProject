using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIbmProject
{
    internal class JaggedArray
    {
        public JaggedArray() {
            int[][] jaggedArray = new int[3][]
            {
                new int [] {1, 0, 6},
                new int [] {2, 5},
                new int[] {3, 6}
            };

                //print jagged array

                foreach (var row in jaggedArray)
                { 
                    foreach (var item in row)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
            }
        }
    }
}
