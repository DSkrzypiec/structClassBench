using System.Collections.Generic;
using StructClassBench.Calculators;
using StructClassBench.Models;
using BenchmarkDotNet.Attributes;

namespace StructClassBench.Benchmarks
{
    [JsonExporter]
    [CsvExporter]
    [MemoryDiagnoser]
    public class SumBenchmark
    {
        private readonly IEnumerable<UserStruct> _userStructs;
        private readonly IEnumerable<UserClass> _userClasses;
        private readonly IEnumerable<IUser> _iusersFromStruct;
        private readonly IEnumerable<IUser> _iusersFromClass;

        private readonly UserStructCalculator _userStructCalculator;
        private readonly UserClassCalculator _userClassCalculator;
        private readonly UserCalculator _userCalculatorFromStruct;
        private readonly UserCalculator _userCalculatorFromClass;

        [Params(1000, 100000, 1000000)]
        public int Size { get; set; }

        public SumBenchmark()
        {
            var userFactory = new UserFactory();
            _userStructs = userFactory.PopulateUserStructs(Size);
            _userClasses = userFactory.PopulateUserClasses(Size);
            _iusersFromStruct = userFactory.PopulateUserStructsAsIUsers(Size);
            _iusersFromClass = userFactory.PopulateUserClassesAsIUser(Size);

            _userStructCalculator = new UserStructCalculator(_userStructs);
            _userClassCalculator = new UserClassCalculator(_userClasses);
            _userCalculatorFromStruct = new UserCalculator(_iusersFromStruct);
            _userCalculatorFromClass = new UserCalculator(_iusersFromClass);
        }

        [Benchmark]
        public void SumUserStructsIEnumerable()
        {
            _userStructCalculator.SumAccountValue();
        }

        [Benchmark]
        public void SumUserClassesIEnumerable()
        {
            _userClassCalculator.SumAccountValue();
        }

        [Benchmark]
        public void SumIUserFromStructsIEnumerable()
        {
            _userCalculatorFromStruct.SumAccountValue();
        }

        [Benchmark]
        public void SumIUserFromClassesIEnumerable()
        {
            _userCalculatorFromClass.SumAccountValue();
        }

        [Benchmark]
        public void SumUserStructsArray()
        {
            _userStructCalculator.SumAccountValueFromArray();
        }

        [Benchmark]
        public void SumUserClassesArray()
        {
            _userClassCalculator.SumAccountValueFromArray();
        }

        [Benchmark]
        public void SumIUserFromStructsArray()
        {
            _userCalculatorFromStruct.SumAccountValueFromArray();
        }

        [Benchmark]
        public void SumIUserFromClassesArray()
        {
            _userCalculatorFromClass.SumAccountValueFromArray();
        }

        [Benchmark]
        public void SumUserStructsList()
        {
            _userStructCalculator.SumAccountValueFromList();
        }

        [Benchmark]
        public void SumUserClassesList()
        {
            _userClassCalculator.SumAccountValueFromList();
        }

        [Benchmark]
        public void SumIUserFromStructsList()
        {
            _userCalculatorFromStruct.SumAccountValueFromList();
        }

        [Benchmark]
        public void SumIUserFromClassesList()
        {
            _userCalculatorFromClass.SumAccountValueFromList();
        }
    }
}
