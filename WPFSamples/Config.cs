using WPFSamples.Model;
using WPFSamples.Pages;
using WPFSamples.ViewModel;

namespace WPFSamples
{
    public partial class MainWindow
    {

        public TypeModel Model { get; set; }

        internal void LoadConfig()
        {
            Model = new TypeModel();
            Model.DataModel.Items.Add(new TypeDataPoint { Name = "Try Catch Example",Type = typeof(TryCatchExample) });
            Model.DataModel.Items.Add(new TypeDataPoint { Name = "For Loop Example", Type = typeof(ForLoopExample) });
            Model.DataModel.Items.Add(new TypeDataPoint { Name = "Array List Example", Type = typeof(ArrayListExample) });
            Model.DataModel.Items.Add(new TypeDataPoint { Name = "File Example", Type = typeof(FileExample) });
            TypeList.ItemsSource = Model.DataModel.Items;
        }
    }
}
