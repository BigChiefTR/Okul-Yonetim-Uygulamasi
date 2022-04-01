using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G022
{
    class Okul
    {

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void NotEkle(int ogrenciNo, string dersAdi, int not)
        {
            Ogrenci o = this.Ogrenciler.Where(a => a.No == ogrenciNo).FirstOrDefault();

            if (o != null)
            {
                o.Notlar.Add(new DersNotu(dersAdi, not));

                //DersNotu dn = new DersNotu();
                //dn.DersAdi = dersAdi;
                //dn.Notu = not;
                //o.Notlar.Add(dn);
            }
        }


        public void OgrenciEkle(int no, string ad, string soyad, DateTime dogumTarihi, CINSIYET cinsiyet, SUBE sube)
        {
            Ogrenciler.Add(new Ogrenci(no, ad, soyad, dogumTarihi, cinsiyet, sube));
        }




    }


}

