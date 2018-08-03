using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFSamples.Common;

namespace WPFSamples.Model
{
    [Serializable]
    public class PersonsInfo :NodeCollection, IEnumerable<Node>
    {
        public PersonsInfo()
        {
            Persons = new Persons();
            Name = "Root";
            Persons.Initialize();
        }

        public Persons Persons { get; set; }

        public override Collection<Node> Children => Persons.Children;
        

        public override void Add(Node node)
        {
            Children.Add(node);
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return Children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Children.GetEnumerator();
        }
    }
}
