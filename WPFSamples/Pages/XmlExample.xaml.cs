﻿using System.IO;
using System.Windows.Controls;
using System.Xml.Serialization;
using WPFSamples.Common;
using WPFSamples.Controls;
using WPFSamples.Model;

namespace WPFSamples.Pages
{
    /// <summary>
    /// Interaction logic for XmlExample.xaml
    /// </summary>
    public partial class XmlExample : Page
    {
        public XmlExample()
        {
            InitializeComponent();
        }

        private void OnXmlGenerate(object sender, System.Windows.RoutedEventArgs e)
        {
            NodeCollection childs = new Persons("Vinayaka");
            childs.Initialize();
            childs.Add(new Person() { Name = "Son of ----" });
            PersonsInfo info = new PersonsInfo();
            info.Persons.Add(childs);
            Stream stream = null;
            using(stream = File.Open("sample.xml", FileMode.Create))
            {
                TextWriter writer = new StreamWriter(stream);
                XmlSerializer serializer = new XmlSerializer(typeof(PersonsInfo));
                serializer.Serialize(writer, info);
                writer.Close();
                Output.Content = "File Created";
            }
        }

        private async void OnXmlRead(object sender, System.Windows.RoutedEventArgs e)
        {
            Stream stream = null;
            using(stream = File.OpenRead("sample.xml"))
            {
                TextReader reader = new StreamReader(stream);
                
                Output.Content = await reader.ReadToEndAsync();
                reader.Close();

            }
        }

        private void OnXmlReadObject(object sender, System.Windows.RoutedEventArgs e)
        {
            Stream stream = null;
            using (stream = File.OpenRead("sample.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PersonsInfo));
                if (serializer.Deserialize(stream) is PersonsInfo info)
                    PersonsList.ItemsSource = info;

            }
        }

        private void OnGenerateTree(object sender, System.Windows.RoutedEventArgs e)
        {
            Stream stream = null;
            using (stream = File.OpenRead("sample.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PersonsInfo));
                if (serializer.Deserialize(stream) is PersonsInfo info)
                    Output.Content = new XmlTreeView(info);

            }
        }
    }
}
