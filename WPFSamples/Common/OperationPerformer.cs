using System;
using System.Collections.Generic;

namespace WPFSamples.Common
{
    public class OperationPerformer
    {
        public delegate int Addition(int a, int b);
        public event Addition Add;

        private int OnAdd(int valueA, int valueB)
        {
            if (Add == null) return -1;
            return Add.Invoke(valueA, valueB);
        }

        internal void Calculate(IList<string> values, IList<OperationType> operationTypes)
        {
            
        }
    }
}
