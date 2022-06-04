using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kütüphane_Otomasyon
{
    internal class Baglanti
    {
        public MySqlConnection Baglan()
        {
            MySqlConnection conn = new MySqlConnection("Server=172.21.54.3;Database=GT2MTE;uid=GT2MTE;pwd=G9m5m1t2e357.");
            conn.Open();
            return conn;
        }
    }
}
