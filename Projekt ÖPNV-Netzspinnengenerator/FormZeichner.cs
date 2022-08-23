using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_ÖPNV_Netzspinnengenerator
{
    public partial class FormZeichner : Form
    {

        private static FormZeichner instanz;
        public static FormZeichner Instanz
        {
            get
            {
                if(instanz==null)
                {
                    instanz = new FormZeichner();
                }
                return instanz;
            }
        }

        private FormZeichner()
        {   
            InitializeComponent();
            
            
        }
        private FormHaltestellen formHaltestellen = null; 

        private void btnZurueckHalte_Click(object sender, EventArgs e)
        {
            FormHaltestellen.Instanz.LadDichNochmalNeu();
            FormHaltestellen.Instanz.Show();
            Visible = false;
        }
        
        public void LadDichNochmalNeu()
        {

        }

        private void pZeichner_Paint(object sender, PaintEventArgs e)
        {
            foreach (Linie l in Linie.alleLinien)
            {
                l.Zeichnen(e.Graphics);
            }
        }
    }
}
