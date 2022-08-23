using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projekt_ÖPNV_Netzspinnengenerator
{
    public partial class FormHaltestellen : Form
    {

        private static FormHaltestellen instanz = null;
        public static FormHaltestellen Instanz
        {
            get 
            {
                if(instanz==null)
                {
                    instanz = new FormHaltestellen();
                }
                return instanz;
            }
        }

        MySqlConnection conn;
        
        private FormHaltestellen()
        {
            
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=;database=netzspinnengenerator;");
            conn.Open();


            Linie.AlleLinienAusDBLaden();
            foreach (Linie l in Linie.alleLinien)
            {
                lbLinien.Items.Add(l);
            }
            Haltestelle.AlleHaltestellenAusDBLaden();
            foreach (Haltestelle h in Haltestelle.alleHaltestellen)
            {
                lbHaltestellen.Items.Add(h);
            }
            
        }

        private FormLinien formLinien;

        private void btnWechselLinie_Click(object sender, EventArgs e)
        {
            FormLinien.Instanz.LadDichNeu();
            FormLinien.Instanz.Show();
            Visible = false;
            
        }

        public void LadDichNeu()
        {

        }
        private FormZeichner formZeichner;

        private void btnWechselZeichner_Click(object sender, EventArgs e)
        {
            FormZeichner.Instanz.LadDichNochmalNeu();
            FormZeichner.Instanz.Show();
            Visible = false;
            
        }

        public void LadDichNochmalNeu()
        {

        }

        
        private void btnHinzufuegenHaltestellen_Click(object sender, EventArgs e)
        {
            

            string haltestellenname = tbHaltestelle.Text;
            if (haltestellenname == "") return;
            string haltestellenkuerzel = tbHaltestellenkuerzel.Text;
            if (haltestellenkuerzel == "") return;
            string kilo = tbStreckenkilometer.Text;
            if (kilo == "") return;
            float streckenkilometer = float.Parse(kilo);
            string koordX = tbKoordinateX.Text;
            if (koordX == "") return;
            int x = int.Parse(koordX);
            string koordY = tbKoordinateY.Text;
            if (koordY == "") return;
            int y = int.Parse(koordY);

            
            MySqlCommand cmd = conn.CreateCommand();
            
            cmd.CommandText = "insert into haltestellen(haltestellenname,haltestellenkuerzel,streckenkilometer, koordX, koordY) values(@haltestellenname,@haltestellenkuerzel,@streckenkilometer, @koordX, @koordY)";
            
            cmd.Parameters.AddWithValue("@haltestellenname", haltestellenname);
            cmd.Parameters.AddWithValue("@haltestellenkuerzel", haltestellenkuerzel);
            cmd.Parameters.AddWithValue("@streckenkilometer", streckenkilometer);
            cmd.Parameters.AddWithValue("@koordX", koordX);
            cmd.Parameters.AddWithValue("@koordY", koordY);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            long idHaltestellen = cmd.LastInsertedId;

            Haltestelle h = new Haltestelle(idHaltestellen, haltestellenname, haltestellenkuerzel, streckenkilometer, x, y);
            lbHaltestellen.Items.Add(h);
           
        }

        private void btnEntfernenHaltestellen_Click(object sender, EventArgs e)
        {
            Haltestelle h = (Haltestelle)lbHaltestellen.SelectedItem;
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from haltestellen where idHaltestellen=" + h.GetidHaltestellen();
            command.ExecuteNonQuery();
            lbHaltestellen.Items.RemoveAt(lbHaltestellen.SelectedIndex);
          
        }

        private void btnZuweisung_Click(object sender, EventArgs e)
        {
           
            Haltestelle h = (Haltestelle)lbHaltestellen.SelectedItem;
            Linie l = (Linie)lbLinien.SelectedItem;

            if (l == null || h == null)
            {
                MessageBox.Show("Auswahl inkorrekt!");
            }
            else
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "update haltestellen set idLinien=" + l.GetIdLinien() + " where idHaltestellen=" + h.GetidHaltestellen();
                command.ExecuteNonQuery();
                MessageBox.Show("Haltestelle wurde Linie hinzugefügt!");
            }
           
        }

        private void lbVerlauf_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbVerlauf.Items.Clear();
            Linie l = (Linie)lbLinien.SelectedItem;
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select * from haltestellen where idLinien=" + l.GetIdLinien() + " " + "order by streckenkilometer";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Haltestelle h = new Haltestelle(reader.GetInt64(0), reader.GetString(1),
                reader.GetString(2), reader.GetFloat(3), reader.GetInt32(4), reader.GetInt32(5));
                lbVerlauf.Items.Add(h);
            }
            reader.Close();
        }
    }
}
