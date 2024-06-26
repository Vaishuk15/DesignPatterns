using Design_Patterns_Demo.Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Factory.Implementation
{
    public class FactoryClass
    {
        public  IAnimal GetAnimal(string animalType)
        {
            switch (animalType.ToLower())
            {
                case "dog":
                    return new DogConcreteClass();
                case "cat":
                    return new CatConcreteClass();
                default:
                    throw new ArgumentException("Invalid animal type.");
            }
        }
    }
}
