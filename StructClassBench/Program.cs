using BenchmarkDotNet.Running;
using StructClassBench.Benchmarks;

namespace StructClassBench
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<SumBenchmark>();
        }
    }
}
