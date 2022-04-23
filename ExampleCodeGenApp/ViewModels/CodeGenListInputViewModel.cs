using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodeNetworkJH.Toolkit.ValueNode;
using NodeNetworkJH.ViewModels;
using NodeNetworkJH.Views;
using ReactiveUI;

namespace ExampleCodeGenApp.ViewModels
{
    public class CodeGenListInputViewModel<T> : ValueListNodeInputViewModel<T>
    {
        static CodeGenListInputViewModel()
        {
            Splat.Locator.CurrentMutable.Register(() => new NodeInputView(), typeof(IViewFor<CodeGenListInputViewModel<T>>));
        }

        public CodeGenListInputViewModel(PortType type)
        {
            this.Port = new CodeGenPortViewModel { PortType = type };

            if (type == PortType.Execution)
            {
                this.PortPosition = PortPosition.Right;
            }
        }
    }
}
