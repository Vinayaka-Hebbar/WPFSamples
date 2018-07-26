using WPFSamples.Model;

namespace WPFSamples.ViewModel
{
    public class TypeModel
    {
        private TypeInformation dataModel;

        public TypeInformation DataModel
        {
            get { return dataModel; }
            private set { dataModel = value; }
        }

        public TypeModel()
        {
            DataModel = new TypeInformation();
        }

    }
}
