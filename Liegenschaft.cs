using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Liegenschaft
    {
        private int lsId;
        private string lsStrasse;
        private string lsNr;
        private string lsPLZ;
        private string lsOrt;
        private double lsGroesse;
        private int lsVwFk;

        public int LsId { get => lsId; set => lsId = value; }
        public string LsStrasse { get => lsStrasse; set => lsStrasse = value; }
        public string LsNr { get => lsNr; set => lsNr = value; }
        public string LsPLZ { get => lsPLZ; set => lsPLZ = value; }
        public string LsOrt { get => lsOrt; set => lsOrt = value; }
        public double LsGroesse { get => lsGroesse; set => lsGroesse = value; }
        public int LsVwFk { get => lsVwFk; set => lsVwFk = value; }

        public Liegenschaft(int lsId, double lsGroesse, int lsVwFk, string lsStrasse, string lsNr, string lsPLZ, string lsOrt)
        {
            LsId = lsId;
            LsStrasse = lsStrasse;
            LsNr = lsNr;
            LsPLZ = lsPLZ;
            LsOrt = lsOrt;
            LsGroesse = lsGroesse;
            LsVwFk = lsVwFk;
        }
    }
}
