namespace CSharpLearning._0x0001;

public class StaticClass
{
    class A
    {
        public A(string text)
        {
            Console.WriteLine(text);
        }
    }

    internal class B
    {
        static A a1 = new A("A1");
        A a2=new A("A2");

        static B()
        {
            a1 = new A("A3");
        }

        public B()
        {
            a2 = new A("A4");
        }
    }
}