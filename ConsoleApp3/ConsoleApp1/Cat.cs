// See https://aka.ms/new-console-template for more information

public class Cat : Animal 
{
    protected bool IsLazy { get; set; }

    public Cat(string name, string color, decimal weight, bool isLazy) : base(name, color, weight)
    {
        IsLazy = isLazy;
    }

    public new void SaySmth()
    {
        Console.WriteLine("Meow!");
    }

    public override string ToString()
    {
        var isLazy = IsLazy ? "lazy" : "not lazy";

        return $"I'm a cat! My name is {Name}. I'm {isLazy}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Cat cat)
        {
            return Name == cat.Name && Color == cat.Color;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Color);
    }
}