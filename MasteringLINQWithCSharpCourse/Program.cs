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
            var numbers = Enumerable.Range(1, 20).ToArray();

            var results = numbers
                .AsParallel()
                .WithMergeOptions(ParallelMergeOptions.FullyBuffered)// there is NOT Buffered
                .Select(x =>
                {
                    var result = Math.Log10(x);
                    Console.WriteLine($"Produced {result}");
                    return result;
                });
            foreach (var result in results)
            {
                Console.WriteLine($"consumed {result}");
            }
            // 34. Merge Options
        }
    }
}
