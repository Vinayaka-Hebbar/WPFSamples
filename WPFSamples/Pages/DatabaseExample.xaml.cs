using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using WPFSamples.Common;

namespace WPFSamples.Pages
{
    /// <summary>
    /// Interaction logic for DatabaseExample.xaml
    /// </summary>
    public partial class DatabaseExample : Page
    {
        private DbManager dbManager;
        public DatabaseExample()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            dbManager = new DbManager("ELPIS-L019", "CustomerDb", "sa", "Testing123$");
            dbManager.StatusChange += OnStatusChange;
        }

        private void OnStatusChange(string status)
        {
            StatusLabel.Content = status;
        }

        private void OnOpenConnection(object sender, RoutedEventArgs e)
        {
            dbManager.ToggleConnection();
        }

        private async void OnExecuteNoQueryAsync(object sender, RoutedEventArgs e)
        {
            Output.Content = await dbManager.ExecuteNonAsync(Editor.Text);
        }

        private async void OnExecuteQueryAsync(object sender, RoutedEventArgs e)
        {
            var result = await dbManager.ExecuteReadersync(Editor.Text);
            DataTable dataTable = new DataTable();
            dataTable.Load(result);
            DataGrid grid = new DataGrid
            {
                ItemsSource = dataTable.DefaultView
            };
            Output.Content = grid;
        }
    }
}
