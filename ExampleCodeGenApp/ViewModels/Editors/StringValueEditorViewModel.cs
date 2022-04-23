using ExampleCodeGenApp.Views.Editors;
using NodeNetworkJH.Toolkit.ValueNode;
using ReactiveUI;

namespace ExampleCodeGenApp.ViewModels.Editors
{
    public class StringValueEditorViewModel : ValueEditorViewModel<string>
    {
        static StringValueEditorViewModel()
        {
            Splat.Locator.CurrentMutable.Register(() => new StringValueEditorView(), typeof(IViewFor<StringValueEditorViewModel>));
        }

        public StringValueEditorViewModel()
        {
            Value = "";
        }
    }
}
