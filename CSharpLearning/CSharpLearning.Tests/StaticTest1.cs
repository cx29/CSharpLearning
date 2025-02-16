using CSharpLearning._0x0001;
using Xunit;

namespace CSharpLearning.CSharpLearning.Tests;

public class StaticTest1
{
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
}