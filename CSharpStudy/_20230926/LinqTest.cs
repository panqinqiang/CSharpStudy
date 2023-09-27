namespace CSharpStudy._20230926;

public class LinqTest
{
    static void LinqTest1()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

        var evenNumbers = numbers.Where(num => num % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }

    static void LinqTest2()
    {
        List<string> names = new List<string> { "Alice", "Bob", "Eve", "Charlie" };

        // 使用Lambda表达式按字母顺序排序
        var sortedNames = names.OrderBy(name => name);

        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
    
    static void LinqTest3()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Eve", Age = 22 },
            new Person { Name = "Charlie", Age = 35 }
        };

        // 使用Lambda表达式选择只包含姓名的新集合
        var names = people.Select(people => people.Name);

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
    
    static void LinqTest4()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

        // 使用Lambda表达式筛选大于3的数字
        var filteredNumbers  = numbers.Where(number=>number > 3);
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}