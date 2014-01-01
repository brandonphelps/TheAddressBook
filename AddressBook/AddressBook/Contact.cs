using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contact
    {
      public Contact(Book b, string c)
      {
        name = c;
        assignedBook = b;
      }

      public string name { get; private set; }
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
