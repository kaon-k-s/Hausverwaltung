using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Mieter
    {
        private int mId;
        private string mName;
        private string mVorname;
        private DateTime einzugsdat;

        public int MId { get => mId; set => mId = value; }
        public string MName { get => mName; set => mName = value; }
        public string MVorname { get => mVorname; set => mVorname = value; }
        public DateTime Einzugsdat { get => einzugsdat; set => einzugsdat = value; }

        public Mieter(int mId, string mName, string mVorname, DateTime einzugsdat)
        {
            MId = mId;
            MName = mName;
            MVorname = mVorname;
            Einzugsdat = einzugsdat;
        }
    }
}
