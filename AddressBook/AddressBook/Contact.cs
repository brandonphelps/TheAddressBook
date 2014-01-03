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

      public Contact(Book b)
      {
        firstName = "First";
        middleName = "Middle";
        lastName = "Last";
        assignedBook = b;
        id = next_id++;
      }

      public Contact(Book b, string c, int id)
      {
        firstName = c;
        assignedBook = b;
        this.id = id;
        if(next_id <= id)
        {
          next_id = id + 1;
        }
      }

      public string firstName { get; set; }
      public string middleName { get; set; }
      public string lastName { get; set; }
      public string phone { get; set; }
      public string emailAddress { get; set; }
      public string streetAddress { get; set; }
      public DateTime birthday { get; set; }
      public Book assignedBook { get; private set; }
      public bool isSaved { get; set; }
      public override string ToString()
      {
        return firstName + " " + lastName;
      }
    }
}
