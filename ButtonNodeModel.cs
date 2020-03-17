using System;
using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using Dynamo.UI.Commands;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;

namespace DynamoUI
{
    [NodeName("UI.Slider")]
    [NodeDescription("A sample Node Model with custom Wpf UI.")]
    [NodeCategory("DynamoUI")]
    [OutPortNames(">")]
    [OutPortTypes("double")]
    [OutPortDescriptions("Double")]
    [IsDesignScriptCompatible]
    public class ButtonNodeModel : NodeModel
    {
        #region public methods

        [IsVisibleInDynamoLibrary(false)]
        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAsNodes)
        {
            DoubleNode doubleNode = AstFactory.BuildDoubleNode(number);
            //var funcNode = AstFactory.BuildFunctionCall(
            //    new Func<double, double, double>(NodeModelsEssentialsFunctions.Multiply),
            //    new List<AssociativeNode>() { doubleNode, doubleNode }
            //    );

            return new[]
            {
                AstFactory.BuildAssignment(
                    GetAstIdentifierForOutputIndex(0), doubleNode)
            };
        }

        #endregion


        #region private members

        double number;
        double maximumValue;
        double minimumValue;
        readonly double step;

        #endregion

        #region properties

        [IsVisibleInDynamoLibrary(false)] public DelegateCommand IncreaseCommand { get; set; }

        [IsVisibleInDynamoLibrary(false)] public DelegateCommand DecreaseCommand { get; set; }

        public double MinimumValue
        {
            get => minimumValue;
            set
            {
                minimumValue = value;
                RaisePropertyChanged("MinimumValue");
            }
        }

        public double MaximumValue
        {
            get => maximumValue;
            set
            {
                maximumValue = value;
                RaisePropertyChanged("MaximumValue");
            }
        }

        public double Number
        {
            get => number;
            set
            {
                number = Math.Round(value, 2);
                ;
                RaisePropertyChanged("Number");

                OnNodeModified();
            }
        }

        #endregion


        #region constructor

        [JsonConstructor]
        ButtonNodeModel(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(inPorts, outPorts)
        {
        }

        public ButtonNodeModel()
        {
            RegisterAllPorts();

            IncreaseCommand = new DelegateCommand(IncreaseNumber);
            DecreaseCommand = new DelegateCommand(DecreaseNumber);

            MinimumValue = 0.0;
            MaximumValue = 100.0;
            step = 1.0;
        }

        #endregion

        #region command methods

        void IncreaseNumber(object obj)
        {
            if (Number + step >= MaximumValue)
                Number = MaximumValue;
            else
                Number += step;
        }

        void DecreaseNumber(object obj)
        {
            if (Number - step <= MinimumValue)
                Number = MinimumValue;
            else
                Number += -step;
        }

        #endregion
    }
}