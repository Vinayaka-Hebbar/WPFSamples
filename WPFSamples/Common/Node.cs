namespace WPFSamples.Common
{
    public class Node : INode
    {
        public Node(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
