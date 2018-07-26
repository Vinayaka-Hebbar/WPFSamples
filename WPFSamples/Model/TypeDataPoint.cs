using System;

namespace WPFSamples.Model
{
    public class TypeDataPoint
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Type type;

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
