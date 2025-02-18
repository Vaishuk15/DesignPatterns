using Design_Patterns_Demo.Abstract_Factory.Implementation;
using Design_Patterns_Demo.Abstract_Factory.Implementation.Factories;
using Design_Patterns_Demo.Abstract_Factory.Interface;
using Design_Patterns_Demo.Adapter.Implementation;
using Design_Patterns_Demo.Adapter.Interface;
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
     //(new object is created everytime for every implementation)
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

     //Adapter Pattern
        // Using adapter to integrate ThirdPartyPaymentGateway with our system
        ThirdPartyPaymentGateway thirdPartyGateway = new ThirdPartyPaymentGateway();
        IPaymentProcessor adapter = new PaymentGatewayAdapter(thirdPartyGateway);

        // Client code (PaymentService) works with the common interface
        PaymentService paymentService = new PaymentService(adapter);

        paymentService.MakePayment(100.50m);
    }
}