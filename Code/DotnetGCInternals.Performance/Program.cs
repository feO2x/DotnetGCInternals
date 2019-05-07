using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace DotnetGCInternals.Performance
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, CreateDefaultConfig());
        }

        private static IConfig CreateDefaultConfig() =>
            DefaultConfig.Instance
                         .With(Job.Core)
                         .With(MemoryDiagnoser.Default);
    }
}