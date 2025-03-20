using CSharpLearning._0x0004;
using Xunit;
using Xunit.Abstractions;

namespace CSharpLearning.CSharpLearning.Tests;

public class FlagsEnumTest
{
    private readonly ITestOutputHelper _output;

    public FlagsEnumTest(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void Test()
    {
        var permission = FlagsEnum.Permission.Read | FlagsEnum.Permission.Write;

        Assert.Equal(FlagsEnum.Permission.Read, permission & FlagsEnum.Permission.Read);
        _output.WriteLine(permission.ToString());
    }
}