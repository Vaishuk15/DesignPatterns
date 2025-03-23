using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Demo.Observer.Interface;

namespace Design_Patterns_Demo.Observer.Implementation
{
    public class ConcreteObserver : IObserver
    {
        private string _name;
        public ConcreteObserver(string name) => _name = name;
        public void Update(string message) => Console.WriteLine($"{_name} received update: {message}");
    }
}
