using CSharpLearning._0x0002;
using Xunit;
using Xunit.Abstractions;

namespace CSharpLearning.CSharpLearning.Tests;

public class ArrayTest
{
    private readonly ITestOutputHelper _testOutputHelper;

    public ArrayTest(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        int[,] array=new int[,]
        {
            { 1, 2, 3 }, 
            { 4, 5, 6 },
            { 5, 7, 8 },
        };
        int target = 5;
        var arrayClass = new TwoArray();
        var res=arrayClass.FindNumFromArray(array, target);
        _testOutputHelper.WriteLine(res);
    }
}