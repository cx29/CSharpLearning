using System;
using System.Collections.Generic;
using StrategicMode.Interface;

namespace StrategicMode.Factory
{
    public class ComparisonStrategyFactory<T>
    {
        /// <summary>
        /// 通过委托注册和动态创建实例
        /// </summary>
        private readonly Dictionary<string, Func<IComparisonStrategy<T>>> _strategies =
            new Dictionary<string, Func<IComparisonStrategy<T>>>();

        /// <summary>
        /// 注册策略创建委托
        /// </summary>
        /// <param name="key"></param>
        /// <param name="factory"></param>
        public void Register(string key,Func<IComparisonStrategy<T>> factory)
        {
            _strategies[key] = factory;
        }

        /// <summary>
        /// 创建指定key对应的策略实例
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException"></exception>
        public IComparisonStrategy<T> Create(string key)
        {
            return _strategies.TryGetValue(key, out var factory) ? 
                factory.Invoke() //如果存在则创建实例
                : throw new KeyNotFoundException();//否则抛异常
        }
    }
}