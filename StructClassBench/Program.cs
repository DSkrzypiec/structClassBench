using BenchmarkDotNet.Running;
using StructClassBench.Benchmarks;

namespace StructClassBench
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumSummary = BenchmarkRunner.Run<SumBenchmark>();
            var modifySummary = BenchmarkRunner.Run<EachElementModifyBenchmark>();
        }
    }
}
