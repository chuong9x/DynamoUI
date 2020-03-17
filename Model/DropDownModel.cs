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
    public class DropdownModel : DSDropDownBase
    {
        public DropdownModel() : base("Name of the output") { }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();
            Dictionary<string, int> dropdownItems = new Dictionary<string, int> {
            { "Test1", 1 },
            { "Test2", 2 },
            { "Test3", 3 },
            { "Test4", 4 },
        };
            foreach (KeyValuePair<string, int> item in dropdownItems)
            {
                Items.Add(new DynamoDropDownItem(item.Key, item.Value));
            }
            return SelectionState.Restore;
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            if (Items.Count == 0 ||
                SelectedIndex == -1) //NB! This line is crucial for some reason
            //https://forum.dynamobim.com/t/c-dropdown/17503/6
            {
                return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
            }

            var intNode = AstFactory.BuildIntNode((int)Items[SelectedIndex].Item);
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), intNode);
            return new List<AssociativeNode> { assign };
        }
    }
}