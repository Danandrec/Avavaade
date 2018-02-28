using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avavaade
{
    public class esmaspaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class teisipaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class kolmapaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class neljapaev
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class reede
    {
        public string tund { get; set; }
        public string algus { get; set; }
        public string lopp { get; set; }
        public string aine { get; set; }
        public string grupp { get; set; }
        public string opetaja { get; set; }
        public string ruum { get; set; }
    }

    public class tunnid
    {
        public List<Esmaspaev> esmaspaev { get; set; }
        public List<Teisipaev> teisipaev { get; set; }
        public List<Kolmapaev> kolmapaev { get; set; }
        public List<Neljapaev> neljapaev { get; set; }
        public List<Reede> reede { get; set; }
    }

    public class RootObject5
    {
        public string nadal { get; set; }
        public Tunnid tunnid { get; set; }
        public string viimane_muudatus { get; set; }
    }
}