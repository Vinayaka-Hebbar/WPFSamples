using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFSamples.Common;

namespace WPFSamples.Model
{
    public class ExplorerInformation : IDirectory
    {
        public ExplorerInformation()
        {
            Items = new ObservableCollection<IInfo>();
        }

        public ObservableCollection<IInfo> Items { get; set; }

        public bool IsLoaded { get; set; }

        public IList<IInfo> InfoList => Items;

        public string Name => "Root";

        public string Path => "/";

        public void Add(IInfo info)
        {
            Items.Add(info);
        }
    }
}
