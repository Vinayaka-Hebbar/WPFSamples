using System;
using System.Xml.Serialization;
using WPFSamples.Model;

namespace WPFSamples.Common
{
    [XmlInclude(typeof(Person))]
    [XmlInclude(typeof(Persons))]
    [Serializable]
    public class Node : INode
    {
        public virtual string Name { get; set; }
    }
}
