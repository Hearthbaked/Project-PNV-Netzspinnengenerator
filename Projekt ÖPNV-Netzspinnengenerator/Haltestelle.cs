using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Projekt_ÖPNV_Netzspinnengenerator
{
    class Haltestelle
    {
        public static List<Haltestelle> alleHaltestellen = new List<Haltestelle>();
        public static Dictionary<long, Haltestelle> haltestellenById = new Dictionary<long, Haltestelle>();

        public static void AlleHaltestellenAusDBLaden()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;password=;database=netzspinnengenerator;");
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from haltestellen order by streckenkilometer";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Haltestelle h = new Haltestelle(reader.GetInt64(0), reader.GetString(1),
                reader.GetString(2), reader.GetFloat(3), reader.GetInt32(4), reader.GetInt32(5));
                alleHaltestellen.Add(h);
                haltestellenById[h.idHaltestellen] = h;

            }
            reader.Close();

            
        }


        private long idHaltestellen;
        private string haltestellenname;
        private string haltestellenkuerzel;
        private float streckenkilometer;
        public Point Position { get; }

        public long GetidHaltestellen()
        {
            return idHaltestellen;
        }
        public float GetStreckenkilometer()
        {
            return streckenkilometer;
        }
        public Haltestelle(long idHaltestellen, string haltestellenname, string haltestellenkuerzel, float streckenkilometer,int x,int y)
        {
            this.idHaltestellen = idHaltestellen;
            this.haltestellenname = haltestellenname;
            this.haltestellenkuerzel = haltestellenkuerzel;
            this.streckenkilometer = streckenkilometer;
            Position=new Point(x,y);
            
        }
        public override string ToString()
        {
            return haltestellenname + "||" + haltestellenkuerzel + "||" + streckenkilometer + "||";
        }
    }
}
