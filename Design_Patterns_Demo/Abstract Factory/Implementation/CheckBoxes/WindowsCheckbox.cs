using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Demo.Abstract_Factory.Interface;

namespace Design_Patterns_Demo.Abstract_Factory.Implementation.CheckBoxes
{
    // Concrete Product B1
    public class WindowsCheckbox : ICheckbox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows Checkbox");
        }
    }
}
