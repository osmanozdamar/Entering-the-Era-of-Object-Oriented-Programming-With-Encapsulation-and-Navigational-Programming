using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OOP_Ilkeleri.Entities.Concreate
{
    public class Ogrenci
    {
        
        private string _adSoyadi;
        private int _yasi;
        private string _sinifi;
        private string _basarisizDersleri;


        public Ogretmen Ogretmen { get; set; }  //Navigational property
        public string AdSoyadi
        {
            get { return _adSoyadi; }
            set { _adSoyadi = value; }
        }
        public string Sinifi { get { return _sinifi; } set { _sinifi = value; } }
        public string BasarisizDersleri { get { return _basarisizDersleri; } set { _basarisizDersleri = value; } }
        public int Yasi { get { return _yasi; } set { _yasi = value; } }
        public string Cinsiyeti { get; set; }
        public int DogumYili { get; set; }   

        public string SecmeliDersleri { get; set; }
        public string ZorunluDersleri { get; set; }

        public string BenKimim()
        {
            return $"Merhaba Benim Adım : {_adSoyadi}. Yaşım : {_yasi}. Zorunlu derslerim: {ZorunluDersleri}.  Başarısız derslerim: {BasarisizDersleri}. Ogretmeni: {Ogretmen.AdSoyadi}";
        }













        private string IlkHarfBuyuk(string deger)
        {
            string _ilkHarfBuyuk = deger[0].ToString().ToUpper();
            deger = deger.Substring(1);
            deger = deger.Insert(0, _ilkHarfBuyuk);
            return deger;
        }


       





    }
}
