using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver
{
    //[Serializable()]
    //[xmligrnor]= om du inte vill har i xml
    public class Tournament 
    {

        //kan sparas i data bas eller xml fil
        public string Name { get; set; } = "-";
        public string date { get; set; } = "-";
        public string location { get; set; } = "-";
        public List<judge> judges { get; set; }
        public List<hoppare> hopparelist { get; set; }
        public List<int> number = new List<int>();
        public Tournament()
        {
            judges = new List<judge>();
            hopparelist = new List<hoppare>();
            number = new List<int>();
        }
        

    }
}
