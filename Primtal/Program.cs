using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> primtal = new Queue<int>();

            primtal.Enqueue(2);
            primtal.Enqueue(3);
            primtal.Enqueue(5);
            primtal.Enqueue(7);
            primtal.Enqueue(11);

            

            while (primtal.Count > 0)
            {
                int total = primtal.Dequeue();
                Console.WriteLine(total);
            }
        }
    }
}
