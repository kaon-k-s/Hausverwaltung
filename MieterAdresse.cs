using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class MieterAdresse
    {
        private string maStrasse;
        private string maNr;
        private string maPLZ;
        private string maOrt;

        public string MaStrasse { get => maStrasse; set => maStrasse = value; }
        public string MaNr { get => maNr; set => maNr = value; }
        public string MaPLZ { get => maPLZ; set => maPLZ = value; }
        public string MaOrt { get => maOrt; set => maOrt = value; }

        public MieterAdresse(string maStrasse, string maNr, string maPLZ, string maOrt) 
        {
            MaStrasse = maStrasse;
            MaNr = maNr;
            MaPLZ = maPLZ;
            MaOrt = maOrt;
        }

    }
}
