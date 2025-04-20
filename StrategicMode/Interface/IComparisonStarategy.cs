using StrategicMode.Entity;

namespace StrategicMode.Interface
{
    public interface IComparisonStrategy
    {
        ComparisonResult Compare(object source, ComparisonContext context = null);
    }
}