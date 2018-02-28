using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avavaade
{
    public class Esmaspaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class Teisipaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class Kolmapaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class Neljapaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class Reede
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }
    public class Tunnid
    {
        public List<Esmaspaev> esmaspaev { get; set; }
        public List<Teisipaev> teisipaev { get; set; }
        public List<Kolmapaev> kolmapaev { get; set; }
        public List<Neljapaev> neljapaev { get; set; }
        public List<Reede> reede { get; set; }
    }
}


