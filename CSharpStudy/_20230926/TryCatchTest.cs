namespace CSharpStudy._20230926;

public class TryCatchTest
{
    public void TryCatch()
    {
        try
        {
            // 可能引发异常的代码
            int result = 10 / int.Parse("0");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divide by zero error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid format: " + ex.Message);
        }
        finally
        {
            // 清理资源的代码
        }
    }
}