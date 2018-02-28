using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avavaade
{
    public class GroupOpetajad
    {
        public string user_id { get; set; }
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
    public class RootObject
    {
        public string section { get; set; }
        public string section_name { get; set; }
        public string section_manager { get; set; }
        public int n { get; set; }
        public List<GroupOpetajad> employees { get; set; }
    }
}
