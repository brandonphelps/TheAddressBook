using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contact
    {
      public Contact(string c)
      {
        name = c;
      }

      public string name { get; private set; }
      public string phone { get; private set; }
      public string emailAddress { get; private set; }
      public string streetAddress { get; private set; }
      public DateTime birthday { get; private set; }
      public override string ToString()
      {
        return name;
      }
    }
}
