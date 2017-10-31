using System;
public class Hamster : IAnimal
{
    public string Name { get; set; }
    public void MakeNoise()
    {
        Console.WriteLine( Name + " scoate sunete de hamster");
    }
    public string Eat()
    {
        return "carrots"; 
    }
}