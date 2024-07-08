using System.Xml;

namespace Hausverwaltung
{
    public partial class Form1 : Form
    {
        private List<Liegenschaft> lsList;
        private List<Mieter> mieterList;
        private List<Mieter> mieterSuchList;

        private Datenbank db = new Datenbank();

        public Form1()
        {
            InitializeComponent();

            dispLS();
            dispMieter();

        }

        private void dispLS()
        {
            lsList = db.getLS();
            dgvLS.Rows.Clear();
            double gesamtGr = 0;

            foreach (Liegenschaft ls in lsList)
            {
                dgvLS.Rows.Add(ls.LsId, ls.LsStrasse, ls.LsNr, ls.LsPLZ, ls.LsOrt, ls.LsGroesse);
                gesamtGr += ls.LsGroesse;
            }

            tbGesamtGr.Text = gesamtGr.ToString();
        }
        private void dispMieter()
        {
            mieterList = db.getMieter();
            dgvMieter.Rows.Clear();

            foreach (Mieter m in mieterList)
            {
                dgvMieter.Rows.Add(m.MId, m.MName, m.MVorname, db.getMieterAdresse(m.MId));
            }
        }


        private void btnSuchen_Click(object sender, EventArgs e)
        {
            //List<Mieter> m = mieterList.FindAll(x => x.MName.ToLower().Contains(tbMSuchen.Text.ToLower())
            //|| x.MVorname.ToLower().Contains(tbMSuchen.Text.ToLower()));
            //tbMId.Text = m[0].MId.ToString();

            List<Mieter> mieterSuchList = db.suchenMieter(tbMSuchen.Text);
            dgvMieter.Rows.Clear();

            foreach (Mieter m in mieterSuchList)
            {
                dgvMieter.Rows.Add(m.MId, m.MName, m.MVorname, db.getMieterAdresse(m.MId));
            }
        }

        private void dgvMieter_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            int selectedMieter;
            object cellValue = dgvMieter.CurrentRow.Cells["MMieterIdCol"].FormattedValue;
            Int32.TryParse(cellValue.ToString(), out selectedMieter);

            tbEinzug.Text = db.anzeigMieterInfo(selectedMieter);

            Wohnungsdaten wohndaten = db.anzeigenWohnDaten(selectedMieter);

            tbWNr.Text = wohndaten.WNr.ToString();
            tbLSId.Text = wohndaten.LsId.ToString();
            tbHausNr.Text = wohndaten.HNr.ToString();
            tbStockwerk.Text = wohndaten.Stockwerk;
            tbGr.Text = wohndaten.Groesse.ToString();
            tbAnzRaum.Text = wohndaten.AnzRaum.ToString();
            tbMiete.Text = wohndaten.Miete.ToString();
        }
    }
}
