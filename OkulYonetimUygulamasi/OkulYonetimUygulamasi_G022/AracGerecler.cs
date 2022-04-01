using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi_G022
{
    class AracGerecler
    {

        static public bool SayiMi(string giris)
        {
            foreach (char item in giris)
            {
                if (!Char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }

        static public int SayiAl(string mesaj)
        {
            int sayi;

            do
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();

                if (int.TryParse(giris, out sayi))
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                }

            } while (true);

        }

        static public string IsimAl(string mesaj)
        {
            do
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(giris))
                {
                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                    continue;

                }

                string trimmed = giris.Trim();
                string newStr = "";
                int spaceCounter = 0;
                bool inSpace = false;

                int i;
                for (i = 0; i < trimmed.Length; i++)
                {
                    if (char.IsDigit(trimmed[i]) || char.IsPunctuation(trimmed[i]))
                    {
                        Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                        break;
                    }
                    else if (char.IsWhiteSpace(trimmed[i]))
                    {
                        if (inSpace == false)
                        {
                            newStr += " ";
                            inSpace = true;
                            spaceCounter++;
                        }
                        if (spaceCounter > 1)
                        {
                            Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                            break;
                        }
                        continue;

                    }
                    else if (char.IsLetter(trimmed[i]))
                    {
                        inSpace = false;
                        newStr += trimmed[i];
                    }
                }

                if (i == trimmed.Length)
                {
                    return newStr;
                }

            } while (true);
        }


        static public CINSIYET CinsiyetAl(string mesaj)
        {


            do
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine().ToUpper();

                switch (giris)
                {
                    case "K":
                        return CINSIYET.Kiz;
                    case "E":
                        return CINSIYET.Erkek;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                        break;
                }
            } while (true);
        }

        static public SUBE SubeAl(string mesaj)
        {


            do
            {
                Console.Write(mesaj);
                string giris = Console.ReadLine().ToUpper();

                switch (giris)
                {
                    case "A":
                        return SUBE.A;
                    case "B":
                        return SUBE.B;
                    case "C":
                        return SUBE.C;
                    default:
                        Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                        break;
                }
            } while (true);
        }

        static public DateTime TarihAl(string mesaj)
        {


            do
            {
                Console.Write(mesaj);
                string date = Console.ReadLine();

                DateTime dt;
                if (!DateTime.TryParse(date, out dt))
                {
                    Console.WriteLine("Hatalı giriş yapıldı, tekrar deneyin.");
                }
                else
                {
                    return dt;
                }

            } while (true);
        }
    }
}
