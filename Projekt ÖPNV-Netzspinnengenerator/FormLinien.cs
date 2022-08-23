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
    public partial class FormLinien : Form
    {

        private static FormLinien instanz;
        public static FormLinien Instanz
        {
            get
            {
                if(instanz==null)
                {
                    instanz = new FormLinien();
                    
                }
                return instanz;
            }
        }

        MySqlConnection conn; 
        
        private FormLinien()
        {
            
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=;database=netzspinnengenerator;");
            conn.Open();
            
            foreach(Linie l in Linie.alleLinien)
            {
                lbLinien.Items.Add(l);
            }
            
            
            
        }

        private void btnWechselHalte_Click(object sender, EventArgs e)
        {
            FormHaltestellen.Instanz.LadDichNeu();
            FormHaltestellen.Instanz.Show();
            Visible = false;
            
        }

        public void LadDichNeu()
        {

        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            string linienname = tbLinienbezeichnung.Text;
            if (linienname == "") return;
            string linienart = cbLinienart.Text;
            if (linienart == "") return;

            
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into linien(linienname, linienart) values(@linienname, @linienart)";
            cmd.Parameters.AddWithValue("@linienname", linienname);
            cmd.Parameters.AddWithValue("@linienart", linienart);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;

            Linie l = new Linie(id, linienname, linienart);
            lbLinien.Items.Add(l);
            
        }

        private void btnEntfernen_Click(object sender, EventArgs e)
        {
            
            Linie l = (Linie)lbLinien.SelectedItem;
            
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "delete from linien where idLinien=" + l.GetIdLinien();
            command.ExecuteNonQuery();
            lbLinien.Items.RemoveAt(lbLinien.SelectedIndex);
           
        }
    }
}
