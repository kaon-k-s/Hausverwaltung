using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Wohnungsdaten
    {
        private int wId;
        private int wNr;
        private int lsId;
        private int hNr;
        private string stockwerk;
        private double groesse;
        private int anzRaum;
        private double miete;

        public int WId { get => wId; set => wId = value; }
        public int WNr { get => wNr; set => wNr = value; }
        public int LsId { get => lsId; set => lsId = value; }
        public int HNr { get => hNr; set => hNr = value; }
        public string Stockwerk { get => stockwerk; set => stockwerk = value; }
        public double Groesse { get => groesse; set => groesse = value; }
        public int AnzRaum { get => anzRaum; set => anzRaum = value; }
        public double Miete { get => miete; set => miete = value; }

        public Wohnungsdaten()
        { 
        }
        public Wohnungsdaten(int lsId, int hNr, int wId, int wNr, double groesse, int anzRaum, double miete, string stockwerk)
        {
            WId = wId;
            WNr = wNr;
            LsId = lsId;
            HNr = hNr;
            Stockwerk = stockwerk;
            Groesse = groesse;
            AnzRaum = anzRaum;
            Miete = miete;
        }
    }
}
