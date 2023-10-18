namespace DotNetCoreStudy._20231016;

public class DelegateDemo
{
    delegate string Mydelegate(int n);

    static string SayEnglish(int n)
    {
        return $"hello {n}";
    }
    
    static string SayChinese(int n)
    {
        return $"你好 {n}";
    }

    public void DelegateTest()
    {
        Mydelegate d1 = SayChinese;
        Mydelegate d2 = SayEnglish;
        string a1 = d1(24);
        string a2 = d2(24);
        Console.WriteLine(a1);
        Console.WriteLine(a2);
    }
}