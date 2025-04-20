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
            var factory = new ComparisonStrategyFactory<int>();//创建整型策略工厂
            factory.Register("A", () => new ComparisonFunctionA());//添加构造器

            var context=new ComparisonContext();
            context.Set<int>("test",100);

            if (context.TryGet<int>("test", out var ab))
            {
                Console.WriteLine(ab);
            }
            
            var strategy = factory.Create("A");//需要使用的时候才进行创建

            var result = strategy.Compare(1);


        }
    }
}
