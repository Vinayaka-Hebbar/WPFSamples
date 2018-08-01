using System.Windows;

namespace WPFSamples.Common
{
    public class Operation : DependencyObject
    {

        public static readonly DependencyProperty TypeProperty = DependencyProperty.Register("Type", typeof(OperationType), typeof(Operation));

        public OperationType Type
        {
            get => (OperationType)GetValue(TypeProperty);
            set => SetValue(TypeProperty, value);
        }
    }

    public enum OperationType
    {
        Divide,
        Multiply,
        Minus,
        Plus,
        Equal,
        Remove,
        Clear,
        ClearAll,
        Fraction
    }

    public enum ValueType
    {
        Integer,
        Float,
        Double
    }

    public class ValueItem
    {
        public string Value { get; }
        public ValueType Type { get; }
        public ValueItem(string value, ValueType type = ValueType.Integer)
        {
            Value = value;
            Type = type;
        }

        public ValueItem(object value, ValueType type = ValueType.Integer)
        {
            Value = value.ToString();
            Type = type;
        }

        public int GetInt()
        {
            return int.Parse(Value);
        }

        public double GetDouble()
        {
            return double.Parse(Value);
        }

        public float GetFloat()
        {
            return float.Parse(Value);
        }

        public static ValueItem operator+(ValueItem value1,ValueItem value2)
        {
            switch (value1.Type)
            {
                case ValueType.Integer:
                    return new ValueItem(value1.GetInt() + value2.GetInt());
                case ValueType.Float:
                    return new ValueItem(value1.GetFloat() + value2.GetFloat(),ValueType.Float);
                case ValueType.Double:
                    return new ValueItem(value1.GetDouble() + value2.GetDouble(), ValueType.Double);
            }
            return null;
        }
    }
}
