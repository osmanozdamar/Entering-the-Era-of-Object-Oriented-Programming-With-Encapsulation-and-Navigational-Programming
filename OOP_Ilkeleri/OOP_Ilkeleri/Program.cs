using OOP_Ilkeleri.Entities.Concreate;
using System;
using System.ComponentModel.DataAnnotations;

namespace OOP_Ilkeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmenBerk = new Ogretmen();
            ogretmenBerk.AdSoyadi = "Berk Hoca";
            ogretmenBerk.Brans = ".net Yazilim";
            ogretmenBerk.Sehir = "Ankara";
            ogretmenBerk.TecrubeSuresi = 12;




            Ogrenci gulhan = new Ogrenci();
            gulhan.AdSoyadi = "Gülhan Aksu";
            gulhan.Sinifi = "12/A";
            gulhan.ZorunluDersleri = "Matematik, Fizik, Kimya, Biyoloji, Yazilim";
            gulhan.SecmeliDersleri = "Edebiyat, Felsefe";
            gulhan.BasarisizDersleri = "Dil Bilgisi, Din Kültürü";
            gulhan.Yasi = 17;
            gulhan.Ogretmen= ogretmenBerk;

            Console.WriteLine(gulhan.BenKimim());

            Ogrenci ogr1 = new Ogrenci();
            ogr1.AdSoyadi = "Mehmet Veli";
            ogr1.Cinsiyeti = "Erkek";
            ogr1.DogumYili = 1996;
            ogr1.Ogretmen= ogretmenBerk;
            ogretmenBerk.Ogrenciler = new Ogrenci[] { ogr1, gulhan };



        }
    }
}
