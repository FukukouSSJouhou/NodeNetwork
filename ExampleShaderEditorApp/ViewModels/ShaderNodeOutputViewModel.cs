using System;
using ExampleShaderEditorApp.Model;
using NodeNetworkJH.Toolkit.ValueNode;
using NodeNetworkJH.Views;
using ReactiveUI;

namespace ExampleShaderEditorApp.ViewModels
{
    public class ShaderNodeOutputViewModel : ValueNodeOutputViewModel<ShaderFunc>
    {
        static ShaderNodeOutputViewModel()
        {
            Splat.Locator.CurrentMutable.Register(() => new NodeOutputView(), typeof(IViewFor<ShaderNodeOutputViewModel>));
        }

        public Type ReturnType { get; set; }
    }
}
