using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Demo.Singleton
{
    public class Singleton
    {
        private static Singleton instance;

        // Private constructor to prevent instantiation
        private Singleton() { }

        // Static method to get the singleton instance
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        public void PrintMessage()
        {
            Console.WriteLine("Singleton instance is working.");
        }
    }
}
