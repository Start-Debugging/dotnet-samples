using BenchmarkDotNet.Running;
using UnsafeAccessor.Benchmarks;

BenchmarkRunner.Run<Benchmarks>();

Console.ReadKey();