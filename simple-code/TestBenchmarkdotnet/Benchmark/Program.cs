using Benchmark;
using BenchmarkDotNet.Running;

internal class Program
{
    private static void Main(string[] args)
    {
        BenchmarkRunner.Run<MyParserBenchmark>();
    }
}