using System;

public class Cat : AnimalBase,IAnimal
{
    public string Name { get; set; }

    public void MakeNoise()
    {
        Console.WriteLine(Name + " says Miaw");
    }

    public string Eat()
    {
        return "mice";
    }

    public override void Bites()
    {
        Console.WriteLine("Medium bite");
    }
}