using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu__bu_son_
{
    internal class Ogrenci : Kullanici
    {
        private string bolumad;

        public string Bolumad
        {
            get { return bolumad; }
            set { bolumad = value; }
        }
    }
}
