using CSharpLearning._0x0001;
using Xunit;
using Xunit.Abstractions;

namespace CSharpLearning.CSharpLearning.Tests;

public class StaticTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public StaticTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        //捕获Console输出
        using var sw = new StringWriter();
        Console.SetOut(sw);

        var b = new StaticClass.B();

        //将输出按照换行切割开来
        var output = sw.ToString().Trim().Split(Environment.NewLine);

        //查看断言 Console是否符合预期,如果符合预期则测试成功，如果不符合预期则输出异常点
        //这里需要看到输出的是什么所以故意预期写错
        Assert.Equal(new[] { "A1", "A3", "A2" }, output);
    }

    [Fact]
    public void Test2()//测试静态构造方法帮助实现单例模式
    {
        var obj1 = Singleton.Instance;
        var obj2 = Singleton.Instance;
        if (ReferenceEquals(obj1, obj2))
        {
            _testOutputHelper.WriteLine("Same instance");
        }
        else
        {
            _testOutputHelper.WriteLine("Different instance");
        }
    }
}