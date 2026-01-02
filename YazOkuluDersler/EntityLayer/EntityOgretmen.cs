using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;
        public int OGRTID { get => ogrtid; set => ogrtid = value; }

        private string ogrtad;
        public string OGRTAD { get => ogrtad; set => ogrtad = value; }

        private int ogrtbrans;
        public int OGRTBRANS { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
