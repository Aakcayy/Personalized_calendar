using System;
using System.Collections.Concurrent;

namespace Kişileştirilmiş_Takvim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ad, soyad;
            string cinsiyet;
            int gun, ay, yıl;
            long numara;
            int gunsayisi;


            int isgunu;//İşin ayın hangi gününde yapılacagını tutan değişken.
            int isayi = 1;//İşin kaçıncı ayda yapılacağını tutan değişken.

            Console.WriteLine("      Kisileştirilmiş Takvim");

            Console.WriteLine("\n");

            Console.Write("Adınızı giriniz: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();

            Console.Write("Telefon Numaranızı giriniz: ");
            numara = Convert.ToInt64(Console.ReadLine());

            Console.Write("Cinsiyeti (erkek=E veya kadın=K olarak) giriniz:");
            cinsiyet = Console.ReadLine();

            Console.Write("\n");



            Console.WriteLine("Dogum tarihini sırasıyla gün,ay,yıl şeklinde giriniz:");

            Console.Write("Gün -->");
            gun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ay -->");
            ay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Yıl --> ");
            yıl = Convert.ToInt32(Console.ReadLine());

            // Doğum tarihi
            DateTime dogumGunu = new DateTime(yıl, ay, gun);
            // Bu günün tarihi
            DateTime buGun = DateTime.Today;//Sistem otomatik olarak bugünun tarihini alır.
            // Yıl farkı
            int yas = buGun.Year - dogumGunu.Year;
            // Bu günün tarihinden yıl farkını çıkar. Doğum günü bu
            // tarihten büyük ise yılı bir azalt.
            if (dogumGunu > buGun.AddYears(-yas))
            { yas--; }



            //21 yaşından gün almış olanlar  için takvim aşağıdaki gibidir.

            //21 yaşından gün almış olanlar için aylar  5 haftadır.(Yani 20 yaşındakiler için geçerlidir.)
            if (yas == 20)
            {
                if (cinsiyet == "E")//Erkeklerde haftalar 8 günden oluşmaktadır.Yani erkekler için 1 ay 40 günden oluşmaktadır.Buna göre 1 yıldaki gün sayısı 480 dir.(1 yılı 12 ay kabul edersek.)
                {

                    Console.Write("\n");

                    Console.Write("Kaç gün sonra iş olacağını giriniz:");
                    gunsayisi = Convert.ToInt32(Console.ReadLine());

                    isgunu = gunsayisi % 40;//İşin ayın hangi gününde olduğunu bulmak için bu işlemi  yapıyoruz.


                    while (gunsayisi / 40 != 0)//İşin kaçınçı ayda oldugunu bulmak için bu işlemi  yapıyoruz.

                    {
                        isayi++;


                        gunsayisi = gunsayisi - 40;// Eğer gün sayısı 40 dan büyükse döngü devam eder fakat gün sayısı 40 dan küçük olunca döngüden çıkar.


                    }
                    Console.Write("\n");

                    Console.WriteLine("Sayın {0} {1}  bey {2} yaşındasınız {3}.ayın {4}.gününde işiniz bulunmaktadır. ",ad,soyad,yas,isayi,isgunu);
                }

                   else if (cinsiyet == "K")//Kadınlarda haftalar 6 günden oluşmaktadır.Yani Kadınlar için 1 ay 30 günden oluşmaktadır.Buna göre 1 yıldaki gün sayisi 360 tır.(1 yılı 12 ay kabul edersek.)
                    {
                    Console.Write("\n");

                    Console.Write("Kaç gün sonra iş olacağını giriniz:");
                        gunsayisi = Convert.ToInt32(Console.ReadLine());

                        isgunu = gunsayisi % 30;//İşin ayın hangi gününde olduğunu bulmak için bu işlemi  yapıyoruz.


                        while (gunsayisi / 30 != 0)//İşin kaçınçı ayda oldugunu bulmak için bu işlemi  yapıyoruz.Eğer döngüye girmezse işin 1. ayda olduğunu kabul ediyoruz.

                        {
                        isayi++;


                            gunsayisi = gunsayisi - 30;//Eğer gün sayısı 30 dan büyükse döngü devam eder fakat gün sayısı 30 dan küçük olunca döngüden çıkar.


                    }
                    Console.Write("\n");

                    Console.WriteLine("Sayın {0} {1}  hanım {2} yaşındasınız {3}.ayın {4}.gününde işiniz bulunmaktadır. ", ad, soyad, yas, isayi, isgunu);

                }

                else
                {
                    Console.Write("\n");

                    Console.WriteLine("Cinsiyeti hatalı girdiniz.");
                }

            }



                
           


            //20 yaş dışındakiler için takvim aşağıdaki gibidir.
            //20 yaş dışındaki kişiler için aylar  6 haftadır.

                else
               {
                if (cinsiyet == "E")//Erkeklerde haftalar 8 günden oluşmaktadır.Yani erkekler için 1 ay 48 günden oluşmaktadır.Buna göre 1 yıldaki gün sayısı 576 dır.(1 yılı 12 ay kabul edersek.)
                {
                    Console.Write("\n");

                    Console.Write("Kaç gün sonra iş olacağını giriniz:");
                    gunsayisi = Convert.ToInt32(Console.ReadLine());

                    isgunu = gunsayisi % 48;//İşin ayın hangi gününde olduğunu bulmak için bu işlemi  yapıyoruz.


                    while (gunsayisi /48 != 0)//İşin kaçınçı ayda oldugunu bulmak için bu işlemi  yapıyoruz.

                    {
                        isayi++;


                        gunsayisi = gunsayisi - 48;// Eğer gün sayısı 48 dan büyükse döngü devam eder fakat gün sayısı 48 dan küçük olunca döngüden çıkar.


                    }
                    Console.Write("\n");

                    Console.WriteLine("Sayın {0} {1}  bey {2} yaşındasınız {3}.ayın {4}.gününde işiniz bulunmaktadır. ", ad, soyad, yas, isayi, isgunu);
                }

                else if (cinsiyet == "K")//Kadınlarda haftalar 6 günden oluşmaktadır.Yani Kadınlar için 1 ay 36 günden oluşmaktadır.Buna göre 1 yıldaki gün sayisi 432 dir.(1 yılı 12 ay kabul edersek.)
                {
                    Console.Write("\n");

                    Console.Write("Kaç gün sonra iş olacağını giriniz:");
                    gunsayisi = Convert.ToInt32(Console.ReadLine());

                    isgunu = gunsayisi % 36;//İşin ayın hangi gününde olduğunu bulmak için bu işlemi  yapıyoruz.


                    while (gunsayisi / 36 != 0)//İşin kaçınçı ayda oldugunu bulmak için bu işlemi  yapıyoruz.

                    {
                        isayi++;

                        gunsayisi = gunsayisi - 36;// Eğer gün sayısı 36 dan büyükse döngü devam eder fakat gün sayısı 36/Eğer gün sayısı 30 dan büyükse döngü devam eder fakat gün sayısı 30 dan küçük olunca döngüden çıkar. dan küçük olunca döngüden çıkar.


                    }
                    Console.Write("\n");

                    Console.WriteLine("Sayın {0} {1}  hanım {2} yaşındasınız {3}.ayın {4}.gününde işiniz bulunmaktadır. ", ad, soyad, yas, isayi, isgunu);

                }


                else
                {
                    Console.Write("\n");
                    Console.WriteLine("Cinsiyeti hatalı girdiniz.");
                }


            }
            Console.ReadKey();

            }
       }

    }
