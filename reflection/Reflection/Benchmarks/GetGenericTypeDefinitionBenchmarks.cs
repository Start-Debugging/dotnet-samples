using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Reflection.Benchmarks;

[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]
public class GetGenericTypeDefinitionBenchmarks
{
    private readonly Type _type = typeof(List<int>);

    [Benchmark]
    public Type GetGenericTypeDefinition() => _type.GetGenericTypeDefinition();
}