using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Book
    {
      private static int next_id = 0;
      public int id { get; private set; }
      public bool isSaved { get; set; }
      public string name { get; private set; }
      private List<Contact> contacts;
      
      public Book(string name)
      {
        contacts = new List<Contact>();
        this.name = name;
        id = next_id++;
      }
      
      public Book(string name, int id)
      {
        contacts = new List<Contact>();
        this.name = name;
        this.id = id;
        if(next_id <= id)
        {
          next_id = id+1;
        }
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
