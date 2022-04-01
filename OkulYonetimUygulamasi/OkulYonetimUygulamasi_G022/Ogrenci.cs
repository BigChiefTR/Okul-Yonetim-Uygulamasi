using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G022
{
    class Ogrenci
    {

        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public SUBE Sube { get; set; }
        public float Ortalama { get; }//get metodunda, Notlar listesini kullanarak ortalamayı hesaplayıp döndürsün

        public Adres Adres = new Adres();

        public List<string> Kitaplar = new List<string>();

        public List<DersNotu> Notlar = new List<DersNotu>();

        public string Aciklama { get; set; }

        public Ogrenci(int no, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyad;
            this.DogumTarihi = dogumTarihi;
            this.Cinsiyet = cinsiyet;
            this.Sube = sube;
        }

        public Ogrenci()
        {

        }


    }


    public enum CINSIYET
    {
        Empty,
        Kiz,
        Erkek
    }

    public enum SUBE
    {
        A, B, C
    }



}
