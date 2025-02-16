using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Demo.Abstract_Factory.Interface;

namespace Design_Patterns_Demo.Abstract_Factory.Implementation
{
    public class AbstractFactory
    {
            private readonly IButton _button;
            private readonly ICheckbox _checkbox;

            public AbstractFactory(IUIFactory factory)
            {
                _button = factory.CreateButton();
                _checkbox = factory.CreateCheckbox();
            }

            public void RenderUI()
            {
                _button.Render();
                _checkbox.Render();
            }
        }
}

