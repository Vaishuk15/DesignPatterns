using Design_Patterns_Demo.Abstract_Factory.Implementation;
using Design_Patterns_Demo.Abstract_Factory.Implementation.Factories;
using Design_Patterns_Demo.Abstract_Factory.Interface;
using Design_Patterns_Demo.Factory.Implementation;
using Design_Patterns_Demo.Factory.Interface;
using Design_Patterns_Demo.Singleton;
using static System.Net.Mime.MediaTypeNames;

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

     // Abstract Factory usage
        IUIFactory uiFactory;

        // Assume we get OS type dynamically
        string osType = "Windows"; // or "Mac"

        if (osType == "Windows")
        {
            uiFactory = new WindowsFactory();
        }
        else
        {
            uiFactory = new MacFactory();
        }

        var app = new AbstractFactory(uiFactory);
        app.RenderUI();
    }
}