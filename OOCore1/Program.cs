
ITalkable ta = factory();
ta.Talk();

ITalkable factory()
{
    return new Dog();
}

public interface ITalkable
{
    void Talk();
}

public class Cat : ITalkable
{
    public void Talk()
    {
        Console.WriteLine("Meow");
    }
}
public class Dog : ITalkable
{
    public void Talk()
    {
        Console.WriteLine("Woof");
    }
}
public class Human : ITalkable
{
    public void Talk()
    {
        Console.WriteLine("Hello");
    }
}
