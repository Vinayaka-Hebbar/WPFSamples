using System;
using System.Collections.ObjectModel;
using WPFSamples.Common;

namespace WPFSamples.Model
{ 
    [Serializable]
    public class PersonsInfo : INodeCollection
    {
        public PersonsInfo()
        {
            Persons = new ObservableCollection<Person>();
        }

        public ObservableCollection<Person> Persons { get; set; }

    }
}
