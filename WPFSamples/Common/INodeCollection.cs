using System.Collections.Generic;

namespace WPFSamples.Common
{
    public interface INodeCollection
    {
        IEnumerable<INode> Children { get; }
        string Name { get; }
    }
}
