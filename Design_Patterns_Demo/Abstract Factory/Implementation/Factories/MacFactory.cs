using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Demo.Abstract_Factory.Implementation.Buttons;
using Design_Patterns_Demo.Abstract_Factory.Implementation.CheckBoxes;
using Design_Patterns_Demo.Abstract_Factory.Interface;

namespace Design_Patterns_Demo.Abstract_Factory.Implementation.Factories
{
    // Concrete Factory 2
    public class MacFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}
