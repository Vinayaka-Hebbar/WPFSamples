using System.Collections.ObjectModel;

namespace WPFSamples.Model
{
    public class TypeInformation
    {
        private ObservableCollection<TypeDataPoint> items;

        public ObservableCollection<TypeDataPoint> Items
        {
            get { return items; }
            private set { items = value; }
        }

        public TypeInformation()
        {
            Items = new ObservableCollection<TypeDataPoint>();
        }
    }
}
