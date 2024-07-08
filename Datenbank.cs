using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hausverwaltung
{
    public class Datenbank
    {
        private MySqlConnection con;

        public Datenbank()
        {
            string conStr = "SERVER=localhost;DATABASE=hausverwaltung; UID=root;PASSWORD=''";
            con = new MySqlConnection(conStr);
        }

        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void schliessen()
        {
            if (con != null)
            {
                con.Close();
            }
        }

        public List<Liegenschaft> getLS()
        {
            List<Liegenschaft> liLi = new List<Liegenschaft>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM liegenschaft;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                liLi.Add(
                    new Liegenschaft(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),   //LSId
                        dr.IsDBNull(1) ? -1.0 : dr.GetDouble(1),   //LSGroesse
                        dr.IsDBNull(2) ? -1 : dr.GetInt32(2),   //LSVWFK
                        dr.IsDBNull(3) ? "" : dr.GetString(3),  //LSStrasse
                        dr.IsDBNull(4) ? "" : dr.GetString(4),  //LSNr
                        dr.IsDBNull(5) ? "" : dr.GetString(5),  //LSPLZ
                        dr.IsDBNull(6) ? "" : dr.GetString(6)   //LSOrt
                        )
                    );
            }

            dr.Close();
            schliessen();

            return liLi;
        }
        public List<Mieter> getMieter()
        {
            List<Mieter> liMi = new List<Mieter>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM mieter;";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string s = dr.IsDBNull(3) ? "" : dr.GetDateTime(3).Day +
                                                   "." + dr.GetDateTime(3).Month +
                                                   "." + dr.GetDateTime(3).Year;
                liMi.Add(
                    new Mieter(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),    //MId
                        dr.IsDBNull(1) ? "" : dr.GetString(1),   //Mname
                        dr.IsDBNull(2) ? "" : dr.GetString(2),   //Mvorname
                        Convert.ToDateTime(s)                    //Einzugsdat
                        )
                    );
            }
            dr.Close();
            schliessen();

            return liMi;
        }

        public List<Mieter> suchenMieter(string suchMieter)
        {
            List<Mieter> liMiS = new List<Mieter>();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM mieter WHERE MName LIKE '%" + suchMieter + "%' OR MVorname LIKE '%" + suchMieter + "%';";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string s = dr.IsDBNull(3) ? "" : dr.GetDateTime(3).Day +
                                                   "." + dr.GetDateTime(3).Month +
                                                   "." + dr.GetDateTime(3).Year;
                liMiS.Add(
                    new Mieter(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),    //MId
                        dr.IsDBNull(1) ? "" : dr.GetString(1),   //Mname
                        dr.IsDBNull(2) ? "" : dr.GetString(2),   //Mvorname
                        Convert.ToDateTime(s)                    //Einzugsdat
                        )
                    );
            }
            dr.Close();
            schliessen();

            return liMiS;
        }

        public string getMieterAdresse(int mieterId)
        {
            string mieterAdresse = "";

            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText =
            "SELECT LSStrasse, LSNR, LSPLZ, LSOrt FROM mieter, wohnung, haus, liegenschaft WHERE " + mieterId + " =  WMieterFK and WHausFK = HId and HLSFK = LSId;";
            //"SELECT LSStrasse, LsNR, LSPLZ FROM mieter join wohnung on WMieterFK = " + mieterId + " " +
            //"JOIN  haus on WHausFK = HId " + 
            //"JOIN liegenschaft ON HLSFK = LSId;";

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                mieterAdresse = dr.IsDBNull(0) ? "" : dr.GetString(0);
                mieterAdresse += " " + (dr.IsDBNull(1) ? "" : dr.GetString(1));
                mieterAdresse += " " + (dr.IsDBNull(2) ? "" : dr.GetString(2));
                mieterAdresse += " " + (dr.IsDBNull(3) ? "" : dr.GetString(3));
            }

            dr.Close();
            schliessen();
            return mieterAdresse;
        }

        public string anzeigMieterInfo(int selectedMieter)
        {
            string dat = "";
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText =
            "SELECT Einzugsdatum FROM mieter WHERE MId = " + selectedMieter + ";";

            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dat = dr.IsDBNull(0) ? "" : dr.GetDateTime(0).Day +
                                                  "." + dr.GetDateTime(0).Month +
                                                  "." + dr.GetDateTime(0).Year;
            }

            dr.Close();
            schliessen();
            return dat;
        }

        public Wohnungsdaten anzeigenWohnDaten(int selectedMieter)
        {
            Wohnungsdaten wd = new Wohnungsdaten();
            oeffnen();
            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT liegenschaft.LSId, haus.HNr, wohnung.WId, wohnung.WNr, wohnung.WGroesse, wohnung.WAnzRaum, wohnung.WMiete, wohnung.WStockwerk " +
            "FROM mieter " +
            "JOIN wohnung ON mieter.MId = wohnung.WMieterFK " +
            "JOIN haus ON wohnung.WHausFK = haus.HId " +
            "JOIN liegenschaft ON haus.HLSFK = liegenschaft.LSId " +
            "WHERE mieter.MId = " + selectedMieter + ";";

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                wd = new Wohnungsdaten(
                        dr.IsDBNull(0) ? -1 : dr.GetInt32(0),    //LsId
                        dr.IsDBNull(1) ? -1 : dr.GetInt32(1),    //HNr
                        dr.IsDBNull(2) ? -1 : dr.GetInt32(2),    //WId
                        dr.IsDBNull(3) ? -1 : dr.GetInt32(3),    //WNr
                        dr.IsDBNull(4) ? -1.0 : dr.GetDouble(4), //WGr
                        dr.IsDBNull(5) ? -1 : dr.GetInt32(5),    //WAnzR
                        dr.IsDBNull(6) ? -1.0 : dr.GetDouble(6), //WMiete
                        dr.IsDBNull(7) ? "" : dr.GetString(7)    //WStockwerk
                    );
            }

            dr.Close();
            schliessen();
            return wd;
        }
    }
}
