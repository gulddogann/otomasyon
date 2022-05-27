using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu__bu_son_
{
    internal class Kullanici
    {
        //field
        private int id;
        private string ad;
        private string soyad;
        private string eposta;
        private string telno;
        private string sifre;

        //property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string Eposta
        {
            get { return eposta; }
            set { eposta = value; }
        }
        public string Telno
        {
            get { return telno; }
            set { telno = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
