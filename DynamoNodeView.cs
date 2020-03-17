using Dynamo.Controls;
using Dynamo.Wpf;
using DynamoUI.WPF;

namespace DynamoUI
{
    public class ButtonNodeView : INodeViewCustomization<ButtonNodeModel>
    {
        public void CustomizeView(ButtonNodeModel model, NodeView nodeView)
        {
            Button button = new Button();
            nodeView.inputGrid.Children.Add(button);
            button.DataContext = model;

        }

        public void Dispose()
        {
        }
    }

   
}