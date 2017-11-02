using System;

public class Dog : AnimalBase,IAnimal
{
    public string Name { get; set; }

    public void MakeNoise()
    {
        Console.WriteLine(Name + " am latrat");
    }
    public string Eat()
    {
        return "cats";
    }

    public override void Bites()
    {
        Console.WriteLine("Strong big bite");
    }
}