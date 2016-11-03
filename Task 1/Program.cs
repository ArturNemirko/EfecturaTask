using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 5, 8, 9, 2, 7, 6, 3 };
            Tree tr = new Tree();
            foreach (var item in arr)
            {
                tr.AddRecursion(ref tr.Node, item);
            }
            string str = String.Empty;
            tr.SymmetricalRound(tr.Node, ref str);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
