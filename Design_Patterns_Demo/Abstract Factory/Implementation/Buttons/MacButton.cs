using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Demo.Abstract_Factory.Interface;

namespace Design_Patterns_Demo.Abstract_Factory.Implementation.Buttons
{
    // Concrete Product A2
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Button");
        }
    }
}
