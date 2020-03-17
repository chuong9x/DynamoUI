using System.Collections.Generic;
using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;

namespace DynamoUI
{
    [NodeName("UI.DropDown")]
    [NodeDescription("A sample Node Model with custom Wpf UI.")]
    [NodeCategory("DynamoUI")]
    [OutPortNames(">")]
    [OutPortTypes("double")]
    [OutPortDescriptions("Double")]
    [IsDesignScriptCompatible]
    public abstract class DropDownModel : DSDropDownBase
    {
        public const string outputName = "item";

        public DropDownModel() : base(outputName)
        {
        }

        [JsonConstructor]
        public DropDownModel(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(outputName,
            inPorts, outPorts)
        {
        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            List<DynamoDropDownItem> newItems = new List<DynamoDropDownItem>
            {
                new DynamoDropDownItem("Tywin", 0),
                new DynamoDropDownItem("Cersei", 1),
                new DynamoDropDownItem("Hodor", 2)
            };

            Items.AddRange(newItems);
            SelectedIndex = 0;
            return SelectionState.Restore;
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputastNodes)
        {
            IntNode intNode = AstFactory.BuildIntNode((int) Items[SelectedIndex].Item);
            BinaryExpressionNode assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), intNode);
            return new List<AssociativeNode> {assign};
        }
    }
}