using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
      private static int next_id = 0;
      public int id { get; private set; }
      public Contact(Book b, string c)
      {
        name = c;
        assignedBook = b;
        id = next_id++;
      }

      public Contact(Book b, string c, int id)
      {
        name = c;
        assignedBook = b;
        this.id = id;
        if(next_id <= id)
        {
          next_id = id + 1;
        }
      }

      public string name { get; set; }
      public string phone { get; private set; }
      public string emailAddress { get; private set; }
      public string streetAddress { get; private set; }
      public DateTime birthday { get; private set; }
      public Book assignedBook { get; private set; }
      public bool isSaved { get; set; }
      public override string ToString()
      {
        return name;
      }
    }
}
