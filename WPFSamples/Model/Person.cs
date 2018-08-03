using System;
using WPFSamples.Common;

namespace WPFSamples.Model
{
    [Serializable]
    public class Person : Node
    {
        public override string Name { get; set; }
        public string PhoneNo { get; set; }

    }
}
