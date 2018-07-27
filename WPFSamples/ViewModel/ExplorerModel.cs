using WPFSamples.Model;

namespace WPFSamples.ViewModel
{
    public class ExplorerModel
    {
        public ExplorerModel()
        {
            Model = new ExplorerInformation();
        }

        public ExplorerInformation Model { get; set; }
    }
}
