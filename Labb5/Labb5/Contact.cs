using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Contact
    {
        private string name;

        private Adress adress;
        
        private Email email;
        
        private Phone phone;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Adress Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public Phone Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public Email Email 
        {
            get { return email; }
            set { email = value; }
        }
    }
}
