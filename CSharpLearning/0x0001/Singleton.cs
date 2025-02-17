namespace CSharpLearning._0x0001;

/// <summary>
/// 单例模式,不许被继承
/// </summary>
public sealed class Singleton
{
    private Singleton() { }

    public static Singleton Instance => Nested._instance;

    //内部类，防止外部调用
    class Nested
    {
        //静态构造方法，在调用该类时会首先调用该方法,
        static Nested()
        {
        }
        //在调用静态构造方法前会先初始化该类中的所有静态变量
        internal static readonly Singleton _instance=new Singleton();
    }
}