using System;
using System.Linq;
using ExampleShaderEditorApp.Model;
using ExampleShaderEditorApp.ViewModels.Nodes;
using NodeNetworkJH;
using NodeNetworkJH.Toolkit.ValueNode;
using NodeNetworkJH.ViewModels;
using NodeNetworkJH.Views;
using ReactiveUI;

namespace ExampleShaderEditorApp.ViewModels
{
    public class ShaderNodeInputViewModel : ValueNodeInputViewModel<ShaderFunc>
    {
        static ShaderNodeInputViewModel()
        {
            Splat.Locator.CurrentMutable.Register(() => new NodeInputView(), typeof(IViewFor<ShaderNodeInputViewModel>));
        }

        public ShaderNodeInputViewModel(params Type[] acceptedTypes)
        {
            Editor = null;
            ConnectionValidator = con =>
            {
                Type type = ((ShaderNodeOutputViewModel)con.Output).ReturnType;
                bool isValidType = acceptedTypes.Contains(type);
                return new ConnectionValidationResult(isValidType, 
                    isValidType ? null : new ErrorMessageViewModel($"Incorrect type, got {type.Name} but need one of {string.Join(", ", acceptedTypes.Select(t => t.Name))}"));
            };
        }
    }
}
