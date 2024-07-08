using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Wohnung
    {
        private int wId;
        private int wNr;
        private double wGroesse;
        private double wMiete;
        private string wStockwerk;
        private int wAnzRaum;
        private int wHausFK;
        private int wMieterFK;

        public int WId { get => wId; set => wId = value; }
        public int WNr { get => wNr; set => wNr = value; }
        public double WGroesse { get => wGroesse; set => wGroesse = value; }
        public double WMiete { get => wMiete; set => wMiete = value; }
        public string WStockwerk { get => wStockwerk; set => wStockwerk = value; }
        public int WAnzRaum { get => wAnzRaum; set => wAnzRaum = value; }
        public int WHausFK { get => wHausFK; set => wHausFK = value; }
        public int WMieterFK { get => wMieterFK; set => wMieterFK = value; }

        public Wohnung(int wId, int wNr, double wGroesse, double wMiete, string wStockwerk, int wAnzRaum, int wHausFK, int wMieterFK)
        {
            WId = wId;
            WNr = wNr;
            WGroesse = wGroesse;
            WMiete = wMiete;
            WStockwerk = wStockwerk;
            WAnzRaum = wAnzRaum;
            WHausFK = wHausFK;
            WMieterFK = wMieterFK;        
        }
    }
}
