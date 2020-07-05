using System.Collections.Generic;
using StructClassBench.Calculators;
using StructClassBench.Models;
using BenchmarkDotNet.Attributes;

namespace StructClassBench.Benchmarks
{
    [JsonExporter]
    [CsvExporter]
    [MemoryDiagnoser]
    public class EachElementModifyBenchmark
    {
        private readonly IEnumerable<UserStruct> _userStructs;
        private readonly IEnumerable<UserClass> _userClasses;

        private readonly UserStructCalculator _userStructCalculator;
        private readonly UserClassCalculator _userClassCalculator;

        [Params(1000, 100000, 1000000)]
        public int Size { get; set; }

        public EachElementModifyBenchmark()
        {
            var userFactory = new UserFactory();
            _userStructs = userFactory.PopulateUserStructs(Size);
            _userClasses = userFactory.PopulateUserClasses(Size);

            _userStructCalculator = new UserStructCalculator(_userStructs);
            _userClassCalculator = new UserClassCalculator(_userClasses);
        }

        [Benchmark]
        public void ModifyEachElementInStructList()
        {
            _userStructCalculator.ModifyEachElementFromList();
        }

        [Benchmark]
        public void ModifyEachElementInClassList()
        {
            _userClassCalculator.ModifyEachElementFromList();
        }

        [Benchmark]
        public void ModifyEachElementInStructArray()
        {
            _userStructCalculator.ModifyEachElementFromArray();
        }

        [Benchmark]
        public void ModifyEachElementInClassArray()
        {
            _userClassCalculator.ModifyEachElementFromArray();
        }


    }
}
