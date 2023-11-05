using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace UnsafeAccessor.Benchmarks;

[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net80)]
public class Benchmarks
{
    private readonly Type _type = typeof(List<int>);

    [Benchmark]
    public Type GetGenericTypeDefinition() => _type.GetGenericTypeDefinition();
}