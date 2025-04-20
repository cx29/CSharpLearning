using StrategicMode.Entity;

namespace StrategicMode.Interface
{
    public interface IComparisonStrategy<T>
    {
        /// <summary>
        /// 泛型比较策略接口
        /// </summary>
        /// <param name="source"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        ComparisonResult<T> Compare(T source, ComparisonContext context = null);
    }
}