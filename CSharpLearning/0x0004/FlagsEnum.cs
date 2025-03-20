namespace CSharpLearning._0x0004;

public class FlagsEnum
{
    //Flags是为了让枚举值更可读
    [Flags]
    public enum Permission
    {
        None = 0,
        Read = 1 << 0,
        Write = 1 << 1,
        Execute = 1 << 2,
        Delete = 1 << 3,
    }
}