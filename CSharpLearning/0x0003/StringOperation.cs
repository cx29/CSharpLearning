using System.Text;

namespace CSharpLearning._0x0003;

public class StringOperation
{
    public void CompareString()
    {
        String str = "Hello";
        str.ToLower();
        str.Insert(0, "World");
        //频繁修改string会造成性能损失, 每次对string类型的字符串进行修改都是新生成一个字符串，并不会在原字符串上进行修改
        StringBuilder sb=new StringBuilder("Hello");
        sb.Append("World");
        //StringBuilder 类型不会创建多个字符串对象， 直接在原有缓冲区上修改
    }
}