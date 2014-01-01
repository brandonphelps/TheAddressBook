using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Book
    {
        private List<Contact> contacts;
        private string name;
        public Book(string name)
        {
            contacts = new List<Contact>();
            this.name = name;
        }

        public void addPerson(Contact c)
        {
            contacts.Add(c);
        }
        
        public List<Contact> getContacts()
        {
          return contacts;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
