using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MasteringLINQWithCSharpCourse
{

    class Program
    {
        static void Main(string[] args)
        {
            var sum = ParallelEnumerable.Range(1, 1000).Sum();

            // we can also do that

            var result = ParallelEnumerable.Range(1, 1000)
                .Aggregate(
                    0,
                    (partialSum,i)=> partialSum +=i,
                    (total, subtotal)=> total += subtotal,
                    i =>i);

            Console.WriteLine($"Sum = {sum}");

            Console.WriteLine($"result = {result}");

            // 35. Custom Aggregation
        }
    }
}
