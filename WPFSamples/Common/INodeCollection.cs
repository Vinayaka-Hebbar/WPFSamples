using System.Collections.Generic;

namespace WPFSamples.Common
{
    public interface INodeCollection
    {
        public IList<INode> Children { get; }
    }
}
