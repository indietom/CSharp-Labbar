using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    class Phone
    {
        private int homePhone;
        private int cellPhone;

        public int HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }

        public int CellPhone
        {
            get { return cellPhone; }
            set { cellPhone = value; }
        }
    }
}
