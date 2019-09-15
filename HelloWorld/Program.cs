using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[3] { 1, 2, 3 };
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(A[i]);
            }
            foreach (var i in A)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("duong world");
            Console.ReadLine();
        }
    }
}
