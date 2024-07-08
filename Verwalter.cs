using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Verwalter
    {
        private int vwId;
        private string vwName;
        private string vwVorname;

        public int VwId { get => vwId; set => vwId = value; }
        public string VwName { get => vwName; set => vwName = value; }
        public string VwVorname { get => vwVorname; set => vwVorname = value; }

        public Verwalter(int vwId, string vwName, string vwVorname)
        {
            VwId = vwId;
            VwName = vwName;
            VwVorname = vwVorname;
        }
    }
}
