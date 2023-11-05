using BenchmarkDotNet.Running;
using UnsafeAccessor.Benchmarks;

namespace Reflection;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmarks>();

        Console.ReadKey();
    }
}
