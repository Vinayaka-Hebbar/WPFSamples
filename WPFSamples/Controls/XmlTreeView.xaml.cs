using System.Windows.Controls;
using WPFSamples.Common;

namespace WPFSamples.Controls
{
    /// <summary>
    /// Interaction logic for XmlTreeView.xaml
    /// </summary>
    public partial class XmlTreeView : UserControl
    {
        public XmlTreeView()
        {
            InitializeComponent();
        }

        public XmlTreeView(INodeCollection collection)
        {
            InitializeComponent();
            XmlTree.ItemsSource = collection.Children;
        }
    }
}
