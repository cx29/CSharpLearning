using StrategicMode.Entity;
using StrategicMode.Interface;

namespace StrategicMode.DoMain
{
    public class ComparisonFunctionA:IComparisonStrategy<int>
    {
        public ComparisonResult<int> Compare(int source, ComparisonContext context = null)
        {
            return new ComparisonResult<int>()
            {
                Type = "EvenCheck", //设置类型标识
                Result = true,
                Value = source,
                Message = "OK",
            };
        }
    }
}