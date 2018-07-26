using WPFSamples.Model;
using WPFSamples.Pages;
using WPFSamples.ViewModel;

namespace WPFSamples
{
    public partial class MainWindow
    {
        private TypeModel model;

        public TypeModel Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        internal void LoadConfig()
        {
            model = new TypeModel();
            model.DataModel.Items.Add(new TypeDataPoint { Name = "Try Catch Example",Type = typeof(TryCatchExample) });
            model.DataModel.Items.Add(new TypeDataPoint { Name = "For Loop Example", Type = typeof(ForLoopExample) });
            TypeList.ItemsSource = model.DataModel.Items;
        }
    }
}
