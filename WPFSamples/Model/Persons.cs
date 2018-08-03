using System.Collections.ObjectModel;
using WPFSamples.Common;

namespace WPFSamples.Model
{
    public class Persons : NodeCollection
    {
        public override string Name { get; set; }

        public Persons()
        {
            
        }

        public Persons(string name)
        {
            Name = name;
        }

        public override void Add(Node node)
        {
            Children.Add(node);
        }

        public override void Initialize()
        {
            Children = new ObservableCollection<Node>();
        }
    }
}
