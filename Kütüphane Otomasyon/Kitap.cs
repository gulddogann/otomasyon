using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kütüphane_Otomasyonu__bu_son_
{
    internal class Kitap
    {
        private int id;
        private string ad;
        private string yayinadi;
        private int kategori;
        private int sayfasayisi;
        private DateTime kutupektarihi;
        private string dil;
        private string yazar;
        private string cevirmen;
        private string editor;
        private int rafno;
        private int sutun;
        private bool kitapdurum;

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

        public string Yayinadi
        {
            get { return yayinadi; }
            set { yayinadi = value; }
        }

        public int Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }

        public int Sayfasayisi
        {
            get { return sayfasayisi; }
            set { sayfasayisi = value; }
        }

        public DateTime Kutupektarihi
        {
            get { return kutupektarihi; }
            set { kutupektarihi = value; }
        }

        public string Dil
        {
            get { return dil; }
            set { dil = value; }
        }

        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }

        public string Cevirmen
        {
            get { return cevirmen; }
            set { cevirmen = value; }
        }
        public string Editor
        {
            get { return editor; }
            set { editor = value; }
        }
        public int Rafno
        {
            get { return rafno; }
            set { rafno = value; }
        }
        public int Sutun
        {
            get { return sutun; }
            set { sutun = value; }
        }

        public bool Kitapdurum
        {
            get { return kitapdurum; }
            set { kitapdurum = value; }
        }
    }
}
