using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;

namespace DynamoUI
{
    [NodeName("UI.Slider")]
    [NodeDescription("Example Slider UI")]
    [NodeCategory("DynamoUI")]
    [InPortNames("NumberMin", "NumberMax")]
    [InPortTypes("double", "double")]
    [InPortDescriptions("Number of cells in the X direction", "Number of cells in the Y direction")]
    [OutPortNames("Number")]
    [OutPortTypes("Autodesk.DesignScript.Geometry.Rectangle[]")]
    [OutPortDescriptions("A list of rectangles")]
    [IsDesignScriptCompatible]
    public class SliderNodeModel : NodeModel
    {
        #region Private Member

        double _sliderValue;

        #endregion


        #region Properties

        public double SliderValue
        {
            get => _sliderValue;
            set
            {
                _sliderValue = value;
                RaisePropertyChanged("SliderValue");
                OnNodeModified(true);
            }
        }

        #endregion

        #region public methods

        // Abstract Syntax Tree  |  Trả về  cây cú pháp trừu tượng chứa dữ liệu từ nút NodeModel
        // AssociativeNode | Map các node đầu vào vào tham số chức năng 
        //
        [IsVisibleInDynamoLibrary(false)]
        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAsNodes)
        {
            List<AssociativeNode> list = new List<AssociativeNode>();

            DoubleNode doubleNode = AstFactory.BuildDoubleNode(SliderValue);

            //var funcNode = AstFactory.BuildFunctionCall(
            //    new Func<double, double, double>(SampleFuntion.MultiplyTwoNumbers),
            //    new List<AssociativeNode>()
            //);

            return new[]
            {
                AstFactory.BuildAssignment(
                    GetAstIdentifierForOutputIndex(0), doubleNode)
            };
        }

        #endregion

        #region Contrustor

        [JsonConstructor]
        SliderNodeModel(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(inPorts, outPorts)
        {
        }

        public SliderNodeModel()
        {
            RegisterAllPorts();
        }

        #endregion
    }
}