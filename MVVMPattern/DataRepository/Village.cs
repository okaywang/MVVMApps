using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class Village
    {
        private List<Person> _persons;
        public Village()
        {
            _persons = new List<Person>();
        }

        public void AddPerson(Person p)
        {
            _persons.Add(p);
        }

        public void RemovePerson(int pId)
        {
            _persons.RemoveAll(p => p.Id == pId);
        }

        public void RemovePerson(Person p)
        {
            var person = _persons.Find(i => i.Id == p.Id);
            person.Name = p.Name;
            person.Height = p.Height;
            person.CardNumber = p.CardNumber;
            person.Birthday = p.Birthday;
        }

        public List<Person> Persons
        {
            get { return _persons; }
        }
    }
}
