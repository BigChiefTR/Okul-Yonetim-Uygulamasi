using System;

namespace OkulYonetimUygulamasi_G022
{
    class Program
    {
        static Okul Okul = new Okul();
        //1) Kullanıcı ile iletişim kurulan,
        //bilgi alış verişi yapılan tüm kodlar bu sayfada yazılacak

        //2) Bu sayfa Öğrenci classını bilmeyecek, Okul classı ara katman olacak.
        //Öğrenci eklemek istediğimizde kullanıcıdan veriler buradan alacağız,
        //okul classındaki bir metoda göndereceğiz, Ogrenci oluşturma ve listeye ekleme işini Okul classındaki metot yapacak.


        static void Main(string[] args)
        {
            Menu();
        }




        static void Menu()
        {
            int say = 1;
            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----");
            Console.WriteLine();
            Console.WriteLine("1-Öğrenci Ekle");
            Console.WriteLine("2-Not Gir");
            Console.WriteLine("3-Öğrencinin ortalamasını gör");
            Console.WriteLine("4-Öğrencinin adresini gir");
            Console.WriteLine("5-Bütün Öğrencileri Listele");
            Console.WriteLine("6-Şubeye Göre Öğrencileri Listele");
            Console.WriteLine("7-Öğrencinin notlarını görüntüle");
            Console.WriteLine("8-Sınıfın Not Ortalamasını Gör");
            Console.WriteLine("9-Cinsiyetine göre öğrenci listele");
            Console.WriteLine("10-Şu tarihten sonra doğan öğrencileri listele");
            Console.WriteLine("11-Tüm öğrencileri semtlerine göre sıralayarak listele");
            Console.WriteLine("12-Okuldaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("13-Okuldaki En başarısız 3 öğrenciyi listele");
            Console.WriteLine("14-Sınıftaki En başarılı 5 öğrenciyi listele");
            Console.WriteLine("15-Sınıftaki  En başarısız 3 öğrenciyi listele");
            Console.WriteLine("16-Öğrenci için açıklama gir");
            Console.WriteLine("17-Öğrencinin açıklamasını gör");
            Console.WriteLine("18-Öğrencinin okuduğu kitabı gir");
            Console.WriteLine("19-Öğrencinin okuduğu kitapları listele");
            Console.WriteLine("20-Öğrencinin okuduğu son kitabı görüntüle");
            Console.WriteLine("21-Öğrenci sil");
            Console.WriteLine("22-Öğrenci güncelle");

            if (say == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Çıkış yapmak için “çıkış” yazıp “enter”a basın.");
            }


            while (true)
            {
                Console.WriteLine();

                if (say > 1)
                {
                    Console.WriteLine("Menüyü tekrar listelemek için “liste”, çıkış yapmak için “çıkış” yazın.");
                }
                say++;
                IslemYap(SecimAl("Yapmak istediğiniz işlemi seçiniz: "));


                // Console.WriteLine();

            }
        }
        static void IslemYap(string secim)
        {
            switch (secim.ToUpper())
            {

                case "1":
                    OgrenciEkle();
                    break;
                case "2":
                    NotGir();
                    break;
                case "3":
                    OgrenciOrtalamaGor();
                    break;
                case "4":
                    OgrenciAdresgir();
                    break;
                case "5":
                    BütünOgrenciListele();
                    break;
                case "6":
                    SubeyeGoreOgrenciListele();
                    break;
                case "7":
                    OgrenciNotuGor();
                    break;
                case "8":
                    SınıfNotOrtalaması();
                    break;
                case "9":
                    CinsiyetGoreOgrenciListele();
                    break;
                case "10":
                    SuTarihtenSonraDoganOgrenciListele();
                    break;
                case "11":
                    TumOgrenciSemtGoreListele();
                    break;
                case "12":
                    Okulda5EnBasarılıOgrenci();
                    break;
                case "13":
                    Okulda3EnBasarısızOgrenci();
                    break;
                case "14":
                    Sınıfta5EnBasarılıOgrenci();
                    break;
                case "15":
                    Sınıfta3EnBasarısızOgrenci();
                    break;
                case "16":
                    OgrenciAcıklamaEkle();
                    break;
                case "17":
                    OgrenciAcıklamaGor();
                    break;
                case "18":
                    OgrenciOkuduguKitapEkle();
                    break;
                case "19":
                    OgrenciOkuduguKitapListele();
                    break;
                case "20":
                    OgrenciOkuduguSonKitap();
                    break;
                case "21":
                    OgrenciSil();
                    break;
                case "22":
                    OgrenciGüncelle();
                    break;
                case "ÇIKIŞ":
                    break;
                case "LİSTE":
                    return;
            }
        }
        static string SecimAl(string text)
        {

            string[] menuSecenekleri = {"1", "2", "3", "4", "5", "6", "7", "8", "9",
                                        "10", "11","12","13","14","15","16","17","18",
                                        "19","20","21","22"};

            while (true)
            {
                Console.Write(text);
                string giris = Console.ReadLine().ToUpper();

                foreach (string mS in menuSecenekleri)
                {
                    if (giris == mS)
                    {
                        Console.WriteLine();
                        return giris;
                    }
                }

                Console.WriteLine();

            }
        }

        static void OgrenciEkle()
        {
            Console.WriteLine("1 - Öğrenci Ekle--------------------------------------------");

            int no = AracGerecler.SayiAl("Öğrencinin numarası: ");

            string ad = AracGerecler.IsimAl("Öğrencinin adı: ");

            string soyad = AracGerecler.IsimAl("Öğrencinin soyadı: ");

            DateTime dogumTarihi = AracGerecler.TarihAl("Öğrencinin doğum tarihi: ");

            CINSIYET cins = AracGerecler.CinsiyetAl("Öğrencinin cinsiyeti(K/E): ");

            SUBE sube = AracGerecler.SubeAl("Öğrencinin sınıf şubesi: ");

            Okul.OgrenciEkle(no, ad, soyad, dogumTarihi, cins, sube);

        }

        static void NotGir()
        {
            Console.WriteLine("2 - Not Gir------------------------------------------------");

            Console.Write("Öğrencinin numarası: ");
            int no = int.Parse(Console.ReadLine());



            Console.Write("Eklemek istediğiniz ders adı: ");
            string dersAdi = Console.ReadLine();
            Console.Write("Eklemek istediğiniz not adedi: ");
            int adet = int.Parse(Console.ReadLine());

            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine(i + ". notu girin: ");
                int not = int.Parse(Console.ReadLine());

                if (not < 0 || not > 100)
                {
                    Console.WriteLine("Girdiğiniz değer 0 ve 100 arasında olmalıdır.");
                    i--;
                    continue;
                }

                Okul.NotEkle(no, dersAdi, not);
            }
        }

        static void OgrenciOrtalamaGor()
        {

        }

        static void OgrenciAdresgir()
        {

        }

        static void BütünOgrenciListele()
        {
            Console.WriteLine("5- Bütün Öğrencileri Listele -------------------------------");
            Console.WriteLine();

            Console.WriteLine("Şube".PadRight(10) + "No".PadRight(10) + "Adı Soyadı".PadRight(25)
                + "Not Ort.".PadRight(16) + "Okuduğu Kitap Say.".PadRight(26));

            foreach (Ogrenci item in Okul.Ogrenciler)
            {
                string tamad = item.Ad + " " + item.Soyad;
                Console.WriteLine(item.Sube.ToString().PadRight(10)+item.No.ToString().PadRight(10)+tamad.PadRight(25)+item.DogumTarihi.ToString().PadRight(16));
            }
        }

        static void SubeyeGoreOgrenciListele()
        {

        }

        static void OgrenciNotuGor()
        {

        }

        static void SınıfNotOrtalaması()
        {

        }

        static void CinsiyetGoreOgrenciListele()
        {

        }

        static void SuTarihtenSonraDoganOgrenciListele()
        {

        }

        static void TumOgrenciSemtGoreListele()
        {

        }

        static void Okulda5EnBasarılıOgrenci()
        {

        }

        static void Okulda3EnBasarısızOgrenci()
        {

        }

        static void Sınıfta5EnBasarılıOgrenci()
        {

        }

        static void Sınıfta3EnBasarısızOgrenci()
        {

        }

        static void OgrenciAcıklamaEkle()
        {

        }

        static void OgrenciAcıklamaGor()
        {

        }

        static void OgrenciOkuduguKitapEkle()
        {

        }

        static void OgrenciOkuduguKitapListele()
        {

        }

        static void OgrenciOkuduguSonKitap()
        {

        }

        static void OgrenciSil()
        {

        }

        static void OgrenciGüncelle()
        {

        }



        static void SahteOgrenciEkle()
        {
            //Okul.OgrenciEkle(10, "Ata", "Kaya", "İstanbul", "Kadıköy");  
            //(öğrenci oluşturmadık, Okul metotları üstünden bilgileri gönderdik)

        }


    }
}
