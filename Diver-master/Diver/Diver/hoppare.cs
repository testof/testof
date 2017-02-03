using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver
{
    public class hoppare
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string dateofbirth { get; set; }
        public bool dive { get; set; }

        //create new property
        public string Display
        {
            get
            {   //string .foramat= to slå ihop multi item to gether add ${1}=value 1
                return string.Format("{0} - {1} - {2}", FirstName, LastName, dateofbirth);
            }
        }
    }
}
