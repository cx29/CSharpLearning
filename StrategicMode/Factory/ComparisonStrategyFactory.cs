using System.Collections.Generic;
using StrategicMode.Interface;

namespace StrategicMode.Factory
{
    public class ComparisonStrategyFactory
    {
        private readonly Dictionary<string, IComparisonStrategy> _strategies = new Dictionary<string, IComparisonStrategy>();

        public void Register(string key, IComparisonStrategy strategy)
        {
            _strategies[key] = strategy;
        }

        public IComparisonStrategy GetStrategy(string key)
        {
            return _strategies.GetValueOrDefault(key);
        }
    }
}