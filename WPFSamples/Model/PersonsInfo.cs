using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using WPFSamples.Common;

namespace WPFSamples.Model
{ 
    [Serializable]
    public class PersonsInfo : INodeCollection,IEnumerable<Person>
    {
        public PersonsInfo()
        {
            Persons = new ObservableCollection<Person>();
        }

        public ObservableCollection<Person> Persons { get; set; }

        public IEnumerable<INode> Children => Persons;

        public string Name => GetType().Name;

        public IEnumerator<Person> GetEnumerator()
        {
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
