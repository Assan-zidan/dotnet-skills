public class Animal 
{
    public virtual void MakeSound() 
    {
        Console.WriteLine("Animal sound");
    }
}

public class Dog : Animal 
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}