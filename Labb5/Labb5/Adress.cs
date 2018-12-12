using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    public enum Country { Sweden }; 
    class Adress
    {
        private string street;
        private string city;
        
        private int zipcode;

        private Country country;
        
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }
    }
}
