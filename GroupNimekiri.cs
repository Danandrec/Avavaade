using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avavaade
{
    public class GroupNimekiri
    {
        public string id { get; set; }
        public string nimi { get; set; }
    }
    public class RootObject2
    {
        public string nadal { get; set; }
        public List<GroupNimekiri> grupp { get; set; }
    }
}
