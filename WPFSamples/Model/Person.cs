using System;
using WPFSamples.Common;

namespace WPFSamples.Model
{
    [Serializable]
    public class Person : INode
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }

    }
}
