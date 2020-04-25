using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Xml;
using Autodesk.DesignScript.Runtime;
using Autodesk.Revit.DB;
using Dynamo.Engine;
using Dynamo.Graph;
using Dynamo.Graph.Nodes;
using ProtoCore.AST.AssociativeAST;
using ProtoCore.Mirror;
using RevitServices.Persistence;

namespace DynamoUI.Model
{
    public class ParameterWrapper
    {
        public string Name { get; set; }
        public string BipName { get; set; }

        public override bool Equals(object obj)
        {
            ParameterWrapper item = obj as ParameterWrapper;

            return item != null && BipName.Equals(item.BipName);
        }

        public override int GetHashCode()
        {
            return BipName.GetHashCode();
        }
    }

    class ComboBoxModel : NodeModel
    {
        public ComboBoxModel()
        {
            RegisterAllPorts();
            foreach (PortModel current in InPorts) current.Connectors.CollectionChanged += Connectors_CollectionChanged;
            ItemsCollection = new ObservableCollection<ParameterWrapper>();
        }

        [IsVisibleInDynamoLibrary(false)]
        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            List<AssociativeNode> list = new List<AssociativeNode>();
            if (!InPorts[0].IsConnected || SelectedItem == null)
            {
                list.Add(AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()));
            }
            else
            {
                AssociativeNode associativeNode = AstFactory.BuildStringNode(SelectedItem.BipName);
                list.Add(AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), associativeNode));
            }

            return list;
        }

        #region Properties

        public event Action RequestChangeBuiltInParamSelector;
        internal EngineController EngineController { get; set; }

        ObservableCollection<ParameterWrapper> _itemsCollection;

        public ObservableCollection<ParameterWrapper> ItemsCollection
        {
            get => _itemsCollection;
            set
            {
                _itemsCollection = value;
                RaisePropertyChanged("ItemsCollection");
            }
        }

        ParameterWrapper _selectedItem;

        public ParameterWrapper SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                RaisePropertyChanged("SelectedItem");
                OnNodeModified(true);
            }
        }

        #endregion

        #region UI Methods

        protected virtual void OnRequestChangeBuiltInParamSelector()
        {
            RequestChangeBuiltInParamSelector?.Invoke();
        }

        void Connectors_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                ItemsCollection.Clear();
                SelectedItem = null;
                OnRequestChangeBuiltInParamSelector();
            }
            else
            {
                OnRequestChangeBuiltInParamSelector();
            }
        }

        List<ParameterWrapper> GetParameters(Element e, string prefix)
        {
            List<ParameterWrapper> items = new List<ParameterWrapper>();
            foreach (Parameter p in e.Parameters)
                if (p.StorageType != StorageType.None)
                {
                    InternalDefinition idef = p.Definition as InternalDefinition;
                    if (idef == null) continue;

                    string bipName = idef.BuiltInParameter.ToString();
                    items.Add(new ParameterWrapper {Name = prefix + " | " + p.Definition.Name, BipName = bipName});
                }

            return items;
        }

        Element GetInputElement()
        {
            Element e = null;
            if (!InPorts[0].IsConnected) return null;

            NodeModel owner = InPorts[0].Connectors[0].Start.Owner;
            int index = InPorts[0].Connectors[0].Start.Index;
            string name = owner.GetAstIdentifierForOutputIndex(index).Name;
            RuntimeMirror mirror = EngineController.GetMirror(name);
            if (!mirror.GetData().IsCollection)
            {
                Revit.Elements.Element element = (Revit.Elements.Element) mirror.GetData().Data;
                if (element != null) e = element.InternalElement;
            }

            return e;
        }

        public void PopulateItems()
        {
            Element e = GetInputElement();
            if (e != null)
            {
                List<ParameterWrapper> items = new List<ParameterWrapper>();

                // add instance parameters
                items.AddRange(GetParameters(e, "Instance"));

                // add type parameters
                if (e.CanHaveTypeAssigned())
                {
                    Element et = DocumentManager.Instance.CurrentDBDocument.GetElement(e.GetTypeId());
                    if (et != null) items.AddRange(GetParameters(et, "Type"));
                }

                ItemsCollection = new ObservableCollection<ParameterWrapper>(items.OrderBy(x => x.Name));
            }

            if (SelectedItem == null) SelectedItem = ItemsCollection.FirstOrDefault();
        }

        #endregion

        #region Node Serialization/Deserialization

        string SerializeValue()
        {
            if (SelectedItem != null) return SelectedItem.Name + "+" + SelectedItem.BipName;
            return string.Empty;
        }

        ParameterWrapper DeserializeValue(string val)
        {
            try
            {
                string name = val.Split('+')[0];
                string bipName = val.Split('+')[1];
                return SelectedItem = new ParameterWrapper {Name = name, BipName = bipName};
            }
            catch
            {
                return SelectedItem = new ParameterWrapper {Name = "None", BipName = "None"};
            }
        }

        protected override void SerializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.SerializeCore(nodeElement, context);

            if (nodeElement.OwnerDocument == null) return;

            XmlElement wrapper = nodeElement.OwnerDocument.CreateElement("paramWrapper");
            wrapper.InnerText = SerializeValue();
            nodeElement.AppendChild(wrapper);
        }

        protected override void DeserializeCore(XmlElement nodeElement, SaveContext context)
        {
            base.DeserializeCore(nodeElement, context);

            XmlNode colorNode = nodeElement.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.Name == "paramWrapper");
            if (colorNode == null) return;

            ParameterWrapper deserialized = DeserializeValue(colorNode.InnerText);
            if (deserialized.Name == "None" && deserialized.BipName == "None") return;
            SelectedItem = deserialized;
        }

        #endregion
    }
}