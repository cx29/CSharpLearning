using System.Collections.Generic;

namespace StrategicMode.Entity
{
    /// <summary>
    /// 上下文，用来传递依赖
    /// </summary>
    public class ComparisonContext
    {
        //中间值字典
        private readonly Dictionary<string, object> _intermediateResults = new Dictionary<string, object>();

        //存储中间值
        public void Set(string key, object value) => _intermediateResults[key] = value;

        //获取
        public T Get<T>(string key) => _intermediateResults.TryGetValue(key, out var value) ? (T)value : default;
        
        //判断是否包含
        public bool Contains(string key) => _intermediateResults.ContainsKey(key);
    }
}