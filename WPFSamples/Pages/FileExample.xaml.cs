using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFSamples.Common;
using WPFSamples.Model;
using WPFSamples.ViewModel;

namespace WPFSamples.Pages
{
    /// <summary>
    /// Interaction logic for FileExample.xaml
    /// </summary>
    public partial class FileExample : Page
    {
        private ExplorerModel explorerModel;
        public FileExample()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            explorerModel = new ExplorerModel();
            DirectoryBox.Text = Environment.CurrentDirectory;
            ExplorerTree.ItemsSource = explorerModel.Model.Items;
        }

        private void OnShowClick(object sender, RoutedEventArgs e)
        {
            explorerModel.Model.Items.Clear();
            explorerModel.Model.IsLoaded = false;
            LoadDirectory(DirectoryBox.Text, explorerModel.Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnExpanded(object sender, RoutedEventArgs e)
        {
            var treeItem = e.OriginalSource as TreeViewItem;
            if (treeItem.DataContext is FolderDataPoint folderItem)
                LoadDirectory(folderItem.Path, folderItem);
        }

        /// <summary>
        /// Loads Directory Info
        /// </summary>
        /// <param name="path"></param>
        private void LoadDirectory(string path, IDirectory parent)
        {
            if (parent.IsLoaded) return;
            if (string.IsNullOrEmpty(path)) return;
            parent.InfoList.Clear();
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo[] folders = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();
            foreach (var entry in folders)
            {
                if (entry.Attributes == FileAttributes.Directory)
                {
                    FolderDataPoint folder = new FolderDataPoint(entry.Name, entry.FullName);
                    DirectoryInfo[] subFolders = entry.GetDirectories();
                    FileInfo[] subFIles = entry.GetFiles();
                    if (subFolders.Length != 0)
                    {
                        foreach (var subFolder in subFolders)
                        {
                            folder.Add(new FolderDataPoint(subFolder.Name, subFolder.FullName));
                        }
                    }
                    if (subFIles.Length != 0)
                    {
                        foreach (var subFIle in subFIles)
                        {
                            folder.Add(new FileDataPoint(subFIle.Name, subFIle.FullName));
                        }
                    }

                    parent.Add(folder);
                }
            }
            foreach (var file in files)
            {
                FileDataPoint fileItem = new FileDataPoint(file.Name, file.FullName);
                parent.Add(fileItem);
            }
            parent.IsLoaded = true;
        }
    }
}
