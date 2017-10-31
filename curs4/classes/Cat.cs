using System;

public class Cat : IAnimal
{
    public string Name { get; set; }

    public void MakeNoise()
    {
        Console.WriteLine(Name + " says Miaw");
    }
}