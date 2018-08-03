using System.Collections.ObjectModel;

namespace WPFSamples.Common
{
    public interface INodeCollection
    {
        Collection<Node> Children { get; }
        string Name { get; }
        void Add(Node node);
    }
}
