using System;

namespace ConsoleApplication1._20231010;

//创建一个抽象产品接口
public interface IProduct
{
    string GetInfo();
}

//创建产品具体类
class ConcreatProductA : IProduct
{
    public string GetInfo()
    {
        return "Product A";
    }
}

class ConcreatProductB : IProduct
{
    public string GetInfo()
    {
        return "Product B";
    }
}

//创建一个简单工厂类
public class SimpleFactory
{
    public static IProduct CreateProduct(string type)
    {
        switch (type.ToLower())
        {
            case "a":
                return new ConcreatProductA();
            case "b":
                return new ConcreatProductB();
            default:
                throw new ArgumentException("Invalid product type");
        }
    }
}

