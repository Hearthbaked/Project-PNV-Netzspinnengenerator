using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Projekt_ÖPNV_Netzspinnengenerator
{
    class Linie
    {
        public static List<Linie> alleLinien = new List<Linie>();
        public static Dictionary<long, Linie> linienById = new Dictionary<long, Linie>();
        public static void AlleLinienAusDBLaden()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;password=;database=netzspinnengenerator;");
            conn.Open();
            

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from linien order by linienart";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Linie l = new Linie(reader.GetInt64(0), reader.GetString(1),reader.GetString(2));
                alleLinien.Add(l);
                linienById[l.idLinien] = l;
            }
            reader.Close();

            
        }


        private long idLinien = 0;
        private string linienname;
        public string linienart;
        public List<Haltestelle> haltestellen=new List<Haltestelle>();

        public long GetIdLinien()
        {
            return idLinien;
        }

        public string GetLinienart()
        {
            return linienart;
        }

        public Linie(long idLinien, string linienname, string linienart)
        {
            this.idLinien = idLinien;
            this.linienname = linienname;
            this.linienart = linienart;
                
        }

        public override string ToString()
        {
            return linienname+" " + "(" + linienart+ ")";
        }

        private static Pen pen = new Pen(Color.Violet);
        public void Zeichnen(Graphics g)
        {
            for(int i=1;i<haltestellen.Count;i++)
            {
                Haltestelle h1 = haltestellen[i - 1];
                Haltestelle h2 = haltestellen[i];
                g.DrawLine(pen, h1.Position, h2.Position);
            }
        }
    }
}
