using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Email
    {
        private string privateAdress;
        private string bussnissAdress;

        public string PrivateAdress
        {
            get { return privateAdress; }
            set { privateAdress = value; }
        }

        public string BussnissAdress
        {
            get { return bussnissAdress; }
            set { bussnissAdress = value; }
        }
    }
}
