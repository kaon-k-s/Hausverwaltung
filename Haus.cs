using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Haus
    {
        private int hId;
        private int hNr;
        private int hStockwerke;
        private int hLsFK;
        public int HId { get => hId; set => hId = value; }
        public int HNr { get => hNr; set => hNr = value; }
        public int HStockwerke { get => hStockwerke; set => hStockwerke = value; }
        public int HLsFK { get => hLsFK; set => hLsFK = value; }

        public Haus(int hId, int hNr, int hStockwerke, int hLsFK)
        {
            HId = hId;
            HNr = hNr;
            HStockwerke = hStockwerke;
            HLsFK = hLsFK;
        }
    }
}
