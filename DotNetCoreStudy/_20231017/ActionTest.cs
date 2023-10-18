namespace DotNetCoreStudy._20231017;

public class ActionTest
{
    //如果一个方法没有返回值，并且方法体只有一行代码，也可以省略方法体的花括号
    public static void Action1()
    {
        Action<int, string> a1 = (age, name) => Console.WriteLine($"年龄{age}，姓名{name}");
    }

    static Func<int, int> f1 = i1 => i1 * 2;
    
    public static void FuncTest(int n)
    {
        int a = f1(32);
    }
}