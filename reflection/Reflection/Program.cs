using BenchmarkDotNet.Running;
using Reflection.Benchmarks;

namespace Reflection;

internal class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<GetGenericTypeDefinitionBenchmarks>();

        Console.ReadKey();
    }
}
