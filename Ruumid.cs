using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avavaade
{
    public class Ruumid
    {
        public string id { get; set; }
        public string nimi { get; set; }

    }
    public class RootObject4
    {
        public string nadal { get; set; }
        public List<Ruumid> ruum { get; set; }
    }

}
