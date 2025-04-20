using System;
using System.Collections.Generic;

namespace StrategicMode.Entity
{
    /// <summary>
    /// 上下文，用来传递依赖
    /// </summary>
    public class ComparisonContext
    {
        /// <summary>
        /// Type用来存储数据类型
        /// string用来存储键
        /// object用来存储值
        /// 按照类型分组的数据存储，避免装箱/拆箱，提升类型安全和效率
        /// </summary>
        private readonly Dictionary<Type, Dictionary<string,object>> _intermediateResults = new Dictionary<Type, Dictionary<string, object>>();

        //存储中间值
        public void Set<T>(string key, T value)
        {
            var type = typeof(T);
            //如果当前类型还没有对应的子字典，则新建一个
            if (!_intermediateResults.TryGetValue(type, out var dict))// 获取该类型对应的内部字典
            {
                //StringComparer.Ordinal保证key的比较是最快的字节序比较
                dict = new Dictionary<string, object>(StringComparer.Ordinal);//初始化内部字典
                _intermediateResults[type] = dict;
            }
            dict[key] = value;
        }

        /// <summary>
        /// 获取指定类型和key对应的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool TryGet<T>(string key, out T value)
        {
            if (_intermediateResults.TryGetValue(typeof(T), out var dict) &&
                dict.TryGetValue(key, out var raw) &&
                raw is T t//t是类型转换之后的值
               )
            {
                value = t;
                return true;
            }

            value = default;
            return false;
        }

        public T Get<T>(string key) => TryGet<T>(key, out var value) ? value : default;
        
        
        //判断是否包含
        public bool Contains<T>(string key)
        {
            return _intermediateResults.TryGetValue(typeof(T), out var dict) && dict.ContainsKey(key);
        }
        
        //清空上下文
        public void Clear()=>_intermediateResults.Clear();
    }
}