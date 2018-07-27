using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace WPFSamples.Pages
{
    /// <summary>
    /// Interaction logic for ArrayListExample.xaml
    /// </summary>
    public partial class ArrayListExample : Page
    {
        private ArrayList arrayList;
        public ArrayListExample()
        {
            InitializeComponent();
            arrayList = new ArrayList()
            {
                "Sample"
            };
            ValueList.ItemsSource = arrayList;
        }

        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            ValueList.ItemsSource = null;
            if (!string.IsNullOrEmpty(ValueBox.Text))
            {
                arrayList.Add(ValueBox.Text);
                ValueList.ItemsSource = arrayList;
            }
        }

        private void OnRemoveClick(object sender, RoutedEventArgs e)
        {
            ValueList.ItemsSource = null;
            if(ValueList.SelectedIndex != -1)
            {
                arrayList.RemoveAt(ValueList.SelectedIndex);
                ValueList.ItemsSource = arrayList;
            }
        }

        private void OnClear(object sender, RoutedEventArgs e)
        {
            ValueList.ItemsSource = null;
            arrayList.Clear();
        }
    }
}
