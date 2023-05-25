// See https://aka.ms/new-console-template for more information

using System;


public class Animal
{
    protected decimal Weight { get; set; }
    protected string Name { get; set; }
    protected string Color { get; set; }

    public Animal(string name, string color, decimal weight)
    {
        Name = name;
        Color = color;
        Weight = weight;
    }

    public void SaySmth()
    {
        Console.WriteLine("I'm an animal!");
    }

    public override string ToString()
    {
        return $"I'm an Animal! My name is {Name}";
    }
}

