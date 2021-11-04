using System;

Console.WriteLine($"\nMaking {nameof(SalamiPizza)}:");
new SalamiPizza().Make();
Console.WriteLine($"\nMaking {nameof(HawaiiPizza)}:");
new HawaiiPizza().Make();
Console.WriteLine($"\nMaking {nameof(RyePizza)}:");
new RyePizza().Make();

public class HawaiiPizza
{
    public void Make()
    {
        Console.WriteLine("Make wheat pizza bottom");
        Console.WriteLine("Add tomato sauce");
        Console.WriteLine("Add mozzarella cheese");
        Console.WriteLine("Add ham");
        Console.WriteLine("Add pineapple");
    }
}

public class SalamiPizza
{
    public void Make()
    {
        Console.WriteLine("Make wheat pizza bottom");
        Console.WriteLine("Add tomato sauce");
        Console.WriteLine("Add mozzarella cheese");
        Console.WriteLine("Add salami");
    }
}

public class RyePizza
{
    public void Make()
    {
        Console.WriteLine("Make rye pizza bottom");
        Console.WriteLine("Add tomato sauce");
        Console.WriteLine("Add mozzarella cheese");
    }
}