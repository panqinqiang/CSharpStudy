using System;

namespace ConsoleApplication1._20231010;

public class Publicsher
{
    public event EventHandler MyEvent;  //定义一个时间

    public void DoSomething()
    {
        Console.WriteLine("Something is happening...");
        OnMyEvent(); //触发事件 
    }

    private void OnMyEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

public class Subscriber
{
    public void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Event handled by Subscriber");
    }
}