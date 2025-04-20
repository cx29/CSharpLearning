using StrategicMode.Entity;
using StrategicMode.Interface;

namespace StrategicMode.DoMain
{
    public class ComparisonFunctionA:IComparisonStrategy
    {
        public ComparisonResult Compare(object source, ComparisonContext context = null)
        {
            var a=new ComparisonResult
            {
                Type = "A"
            };

            return a;
        }
    }
}