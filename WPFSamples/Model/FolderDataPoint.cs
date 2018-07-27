using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFSamples.Common;

namespace WPFSamples.Model
{
    public class FolderDataPoint : IDirectory
    {
        public string Name { get; set; }

        public FolderDataPoint()
        {
            Items = new ObservableCollection<IInfo>();
        }

        public FolderDataPoint(string name, string path)
        {
            Name = name;
            Path = path;
            Items = new ObservableCollection<IInfo>();
        }

        public void Add(IInfo file)
        {
            Items.Add(file);
        }

        public ObservableCollection<IInfo> Items { get; set; }

        public string Path { get; set; }

        public bool IsLoaded { get; set; }

        public IList<IInfo> InfoList => Items;
    }
}
