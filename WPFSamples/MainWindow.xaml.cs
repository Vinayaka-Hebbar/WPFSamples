using System;
using System.Windows;
using System.Windows.Controls;
using WPFSamples.Model;

namespace WPFSamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(TypeList.SelectedIndex != -1)
            {
               var item = TypeList.SelectedItem as TypeDataPoint;

                Frame.Content = Activator.CreateInstance(item.Type);
            }
        }
    }
}
