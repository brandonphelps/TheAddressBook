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

        public Book()
        {
            contacts = new List<Contact>();
        }

        public void addPerson(Contact c)
        {
            contacts.Add(c);
        }
    }
}
