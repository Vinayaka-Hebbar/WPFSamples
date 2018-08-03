using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using WPFSamples.Model;

namespace WPFSamples.Common
{
    [XmlInclude(typeof(Persons))]
    [Serializable]
    public class NodeCollection : Node, INodeCollection
    {
        public virtual Collection<Node> Children { get; set; }

        public override string Name => string.Empty;

        public virtual void Add(Node node)
        {
            Children.Add(node);
        }

        public virtual void Initialize()
        {
            Children = new ObservableCollection<Node>();
        }
    }
}
