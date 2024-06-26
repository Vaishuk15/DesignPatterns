using Design_Patterns_Demo.Factory.Implementation;
using Design_Patterns_Demo.Factory.Interface;
using Design_Patterns_Demo.Singleton;

class Program
{
    static void Main()
    {
        // Singleton usage
        Singleton singleton = Singleton.GetInstance();
        singleton.PrintMessage();

        // Factory usage
        FactoryClass factory = new FactoryClass();

        // Create a dog
        IAnimal dog = factory.GetAnimal("dog");
        dog.MakeSound();  // Output: Woof!

        // Create a cat
        IAnimal cat = factory.GetAnimal("cat");
        cat.MakeSound();  // Output: Meow!
    }
}