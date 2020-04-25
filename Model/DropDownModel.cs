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
<<<<<<< HEAD
<<<<<<< HEAD
    public class DropdownModel : DSDropDownBase
    {
        public DropdownModel() : base("Name of the output") { }
=======
    public class DropdownModel : DSDropDownBase //Old  : RevitDropDownBase
=======
    public abstract class DropDownModel : DSDropDownBase
>>>>>>> parent of fb35697... re
    {
        public const string outputName = "item";

        public DropDownModel() : base(outputName)
        {
        }

<<<<<<< HEAD
        #region SelectionState
>>>>>>> fb3569762488a1d419197fbfe113b1a98c7e91b2
=======
        [JsonConstructor]
        public DropDownModel(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(outputName,
            inPorts, outPorts)
        {
        }
>>>>>>> parent of fb35697... re

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();
<<<<<<< HEAD
<<<<<<< HEAD
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

=======
            Dictionary<string, int> dropdownItems = new Dictionary<string, int>
=======

            List<DynamoDropDownItem> newItems = new List<DynamoDropDownItem>
>>>>>>> parent of fb35697... re
            {
                new DynamoDropDownItem("Tywin", 0),
                new DynamoDropDownItem("Cersei", 1),
                new DynamoDropDownItem("Hodor", 2)
            };

            Items.AddRange(newItems);
            SelectedIndex = 0;
            return SelectionState.Restore;
        }

<<<<<<< HEAD
        #endregion

        #region BuildOutputAST // Abstract Syntax Tree

>>>>>>> fb3569762488a1d419197fbfe113b1a98c7e91b2
        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            if (Items.Count == 0 ||
                SelectedIndex == -1) //NB! This line is crucial for some reason
<<<<<<< HEAD
            //https://forum.dynamobim.com/t/c-dropdown/17503/6
            {
                return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
            }

            var intNode = AstFactory.BuildIntNode((int)Items[SelectedIndex].Item);
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), intNode);
            return new List<AssociativeNode> { assign };
=======

                //https://forum.dynamobim.com/t/c-dropdown/17503/6?u=chuongpqvn
                return new[]
                    {AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode())};

=======
        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputastNodes)
        {
>>>>>>> parent of fb35697... re
            IntNode intNode = AstFactory.BuildIntNode((int) Items[SelectedIndex].Item);
            BinaryExpressionNode assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), intNode);
            return new List<AssociativeNode> {assign};
>>>>>>> fb3569762488a1d419197fbfe113b1a98c7e91b2
        }
    }
}