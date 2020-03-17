using Dynamo.Controls;
using Dynamo.Wpf;

namespace DynamoUI
{
    public class HelloGuiNodeView : INodeViewCustomization<DynamoNodeModel>
    {
        public void CustomizeView(DynamoNodeModel model, NodeView nodeView)
        {
            Slider slider = new Slider();
            nodeView.inputGrid.Children.Add(slider);
            slider.DataContext = model;
        }

        public void Dispose()
        {
        }
    }
}