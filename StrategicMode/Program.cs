using System;
using StrategicMode.DoMain;
using StrategicMode.Entity;
using StrategicMode.Factory;

namespace StrategicMode
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ComparisonStrategyFactory();
            factory.Register("A",new ComparisonFunctionA());

            var context = new ComparisonContext();

            var asb = "asd";
            var a=factory.GetStrategy("A").Compare(asb,context);
        }
    }
}
