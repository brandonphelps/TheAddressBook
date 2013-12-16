using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contact
    {
        private string _name;
        private string _location;
        private string _phone_number;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone_number;
            }
            set
            {
                _phone_number = value;
            }
        }
    }
}
